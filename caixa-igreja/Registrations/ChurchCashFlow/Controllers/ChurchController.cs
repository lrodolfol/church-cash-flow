using AutoMapper;
using ChurchCashFlow.Data;
using ChurchCashFlow.Models;
using ChurchCashFlow.ViewModels;
using ChurchCashFlow.ViewModels.Dtos.Church;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChurchCashFlow.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
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
    public async Task<IActionResult> GetChurches()
    {
        IEnumerable<Church> churches =
            await _context.Churches.AsNoTracking().ToListAsync();

        return Ok(new ResultViewModel<dynamic>(churches));
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetChurch([FromRoute] int id)
    {
        Church church = 
            _context.Churches.Include(x => x.Address).AsNoTracking().FirstOrDefault(x => x.Id == id);

        if (church == null)
            return NotFound(new ResultViewModel<dynamic>());

        ReadChurchDto churchesDto =
            _mapper.Map<ReadChurchDto>(church);

        return Ok(new ResultViewModel<ReadChurchDto>(churchesDto));  
    }

    [HttpPost]
    public async Task<IActionResult> PostChurch()
    {
        return Ok();
    }

    
}