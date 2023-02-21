using AutoMapper;
using ChurchCashFlow.Data;
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
            Church church =
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
        if (churchAddress == null)
            return BadRequest(new ResultViewModel<string>("Register invalid"));

        try
        {
            EditChurchDto churchEditDto = churchAddress.EditChurchDto;
            EditAddressDto addressEditDto = churchAddress.EditAddressDto;

            Address address = _mapper.Map<Address>(addressEditDto);
            Church church = _mapper.Map<Church>(churchEditDto);
            church.Address = address;

            _context.Adresses.Add(address);
            _context.Churches.Add(church);
            _context.SaveChanges();

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            return Created($"/api/v1/church/{church.Id}", new ResultViewModel<ReadChurchDto>(churchReadDto));
        }
        catch (DbException)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1104A"));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1104B"));
        }
    }


}