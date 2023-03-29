using Microsoft.AspNetCore.Mvc;
using Registration.Mapper.DTOs.User;
using Registration.DomainCore.ViewModel;
using Registration.API.Extensions;
using Registration.DomainCore.HandlerAbstraction;

namespace Registration.API.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly IHandler<ReadUserDto,EditUserDto> _handler;

    public UserController(IHandler<ReadUserDto, EditUserDto> handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/user")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpGet("api/v1/user/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPost("api/v1/user")]
    public async Task<IActionResult> Create([FromBody] EditUserDto userEditDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(userEditDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPut("api/v1/user/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditUserDto userEditDto, int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(userEditDto, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpDelete("/api/v1/user/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(),resultViewModel);  
    }
}