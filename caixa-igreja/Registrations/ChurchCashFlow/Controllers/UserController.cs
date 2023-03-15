using ChurchCashFlow.Data.ViewModels.Dtos.User;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using DataModelChurchCashFlow.Context.Interface;
using ChurchCashFlow.Handlers;

namespace ChurchCashFlow.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserContext _userContext;
    private readonly UserHandler _handler;

    public UserController(IUserContext userContext, UserHandler handler)
    {
        _userContext = userContext;
        _handler = handler;
    }

    [HttpGet("api/v1/user")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("api/v1/user/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPost("api/v1/user")]
    public async Task<IActionResult> Create([FromBody] EditUserDto userEditDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(userEditDto);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPut("api/v1/user/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditUserDto userEditDto, int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(userEditDto, id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpDelete("/api/v1/user/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.StatusCode,resultViewModel);  
    }
}