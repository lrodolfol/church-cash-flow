using AutoMapper;
using ChurchCashFlow.Data;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Models;
using ChurchCashFlow.ViewModels;
using ChurchCashFlow.ViewModels.Dtos.Address;
using ChurchCashFlow.ViewModels.Dtos.Church;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ChurchCashFlow.Controllers;

[ApiController]
public class ChurchController : ControllerBase
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public ChurchController(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("/api/v1/church/all")]
    public async Task<IActionResult> GetChurches()
    {
        try
        {
            IEnumerable<Church> churches =
            await _context.Churches.AsNoTracking().ToListAsync();

            IEnumerable<ReadChurchDto> churchReadDto = _mapper.Map<IEnumerable<ReadChurchDto>>(churches);

            return Ok(new ResultViewModel<IEnumerable<ReadChurchDto>>(churchReadDto));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1101A"));
        }
    }

    [HttpGet]
    [Route("/api/v1/church/allWitchAddress")]
    public async Task<IActionResult> GetChurchesWithAddress()
    {
        try
        {
            IEnumerable<Church> churches =
            await _context.Churches.Include(x => x.Address).AsNoTracking().ToListAsync();

            IEnumerable<ReadChurchDto> churchRead = _mapper.Map<IEnumerable<ReadChurchDto>>(churches);

            return Ok(new ResultViewModel<IEnumerable<ReadChurchDto>>(churchRead));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1102A"));
        }
    }

    [HttpGet]
    [Route("/api/v1/church/{id:int}")]
    public async Task<IActionResult> GetChurch([FromRoute] int id)
    {
        try
        {
            var church =
            await _context.Churches.Include(x => x.Address).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (church == null)
                return NotFound(new ResultViewModel<dynamic>());

            ReadChurchDto churchReadDto =
                _mapper.Map<ReadChurchDto>(church);

            return Ok(new ResultViewModel<ReadChurchDto>(churchReadDto));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1103A"));
        }
    }

    [HttpPost]
    [Route("/api/v1/church")]
    public async Task<IActionResult> PostChurch([FromBody] ChurchAddress churchAddress)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        try
        {
            EditChurchDto churchEditDto = churchAddress.EditChurchDto;
            EditAddressDto addressEditDto = churchAddress.EditAddressDto;

            Address address = _mapper.Map<Address>(addressEditDto);
            Church church = _mapper.Map<Church>(churchEditDto);
            church.Address = address;

            await _context.Adresses.AddAsync(address);
            await _context.Churches.AddAsync(church);
            await _context.SaveChangesAsync();

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            return Created($"/api/v1/church/{church.Id}", new ResultViewModel<ReadChurchDto>(churchReadDto));
        }
        catch (DbException)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1104A"));
        }
        catch (Exception)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1104B"));
        }
    }

    [HttpPut]
    [Route("/api/v1/church/{id:int}")]
    public async Task<IActionResult> PutChurch([FromBody] ChurchAddress churchAddress, [FromRoute] int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        try
        {
            var church = await _context.Churches.Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == id);

            if (church == null)
                return NotFound(new ResultViewModel<dynamic>("Object not found", null));

            var address = await _context.Adresses.FirstOrDefaultAsync(x => x.Id == church.Address.Id);

            EditAddressDto addressEditDto = churchAddress.EditAddressDto;
            EditChurchDto churchEditDto = churchAddress.EditChurchDto;

            church = _mapper.Map(churchEditDto, church);
            address = _mapper.Map(addressEditDto, address);

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            await _context.SaveChangesAsync();

            return Ok(new ResultViewModel<ReadChurchDto>(churchReadDto));
        }
        catch (DbException)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1105B"));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1105C"));
        }
    }

    [HttpDelete]
    [Route("/api/v1/church/{id:int}")]
    public async Task<IActionResult> DeleteChurch(int id)
    {
        var church = await _context.Churches.FirstOrDefaultAsync(x => x.Id == id);

        if (church == null)
            return NotFound(new ResultViewModel<dynamic>("Object not found",null));

        try
        {
            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            _context.Churches.Remove(church);
            await _context.SaveChangesAsync();

            return Ok(new ResultViewModel<ReadChurchDto>(churchReadDto));
        }
        catch(DbException)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1106B"));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1106C"));
        }
    }

}