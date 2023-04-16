using Microsoft.AspNetCore.Mvc;
using Registration.Mapper.DTOs.User;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers;
using Microsoft.AspNetCore.Authorization;
using Registration.Mapper.DTOs.UserLogin;

namespace Registration.API.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly UserHandler _handler;
    private readonly CViewModel _viewModel;

    public UserController(UserHandler handler, CViewModel viewModel)
    {
        _handler = handler;
        _viewModel = viewModel;
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("api/v1/user")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("api/v1/user/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPost("api/v1/user")]
    public async Task<IActionResult> Create([FromBody] EditUserCreateDto userEditDto)
    {
        if (!ModelState.IsValid) 
        { 
            _viewModel.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Create(userEditDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpPut("api/v1/user/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditUserDto userEditDto, int id)
    {
        if (!ModelState.IsValid)
        {
            _viewModel.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Update(userEditDto, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpDelete("/api/v1/user/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(),resultViewModel);  
    }
}