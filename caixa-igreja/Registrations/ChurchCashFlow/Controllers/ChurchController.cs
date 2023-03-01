using AutoMapper;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Data.ViewModels.Dtos.Address;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using ChurchCashFlow.Data.Context;
using ChurchCashFlow.Data.Queries;
using System;

namespace ChurchCashFlow.Controllers;

[ApiController]
public class ChurchController : ControllerBase
{
    private readonly DataContext _context;
    private readonly ChurchContext _churchContext;
    private readonly IMapper _mapper;

    public ChurchController(DataContext context, IMapper mapper, ChurchContext churchContext)
    {
        _context = context;
        _mapper = mapper;
        _churchContext = churchContext;
    }

    [HttpGet]
    [Route("/api/v1/church/all")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        try
        {
            var userExpression = ChurchQueries.GetChurchActive(active);
            var churches = await _churchContext.GetAll(active);
            var uss = await churches.Where(userExpression).ToListAsync();

            var churchReadDto = _mapper.Map<IEnumerable<ReadChurchDto>>(uss);

            return Ok(new ResultViewModel<IEnumerable<ReadChurchDto>>(churchReadDto));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1101A"));
        }
    }

    [HttpGet]
    [Route("/api/v1/church/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        try
        {
            var church = await _churchContext.GetOne(id);
          
            if (church == null)
                return NotFound(new ResultViewModel<dynamic>("Object not found"));

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
    [Authorize(Roles = "MINISTERIO")]
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
            church.AddAddress(address);

            var newChurch = await _churchContext.Post(church);

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(newChurch);

            return Created($"/api/v1/church/{church.Id}", new ResultViewModel<ReadChurchDto>(churchReadDto));
        }
        catch (DbException)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1105A"));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1105B"));
        }
    }

    [HttpPut]
    [Route("/api/v1/church/{id:int}")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> PutChurch([FromBody] ChurchAddress churchAddress, [FromRoute] int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        try
        {
            var church = await _churchContext.Put(churchAddress, id);

            if (church == null)
                return NotFound(new ResultViewModel<dynamic>("Object not found", null));

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            return Ok(new ResultViewModel<ReadChurchDto>(churchReadDto));
        }
        catch (DbException)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1106A"));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1106B"));
        }
    }

    [HttpDelete]
    [Route("/api/v1/church/{id:int}")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> DeleteChurch(int id)
    {
        var church = await _context.Churches.FirstOrDefaultAsync(x => x.Id == id);

        if (church == null)
            return NotFound(new ResultViewModel<dynamic>("Object not found",null));

        try
        {
            church.Active = false;
            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            await _context.SaveChangesAsync();

            return Ok(new ResultViewModel<ReadChurchDto>(churchReadDto));
        }
        catch(DbException)
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1107B"));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("Internal Error - CH1107C"));
        }
    }

}