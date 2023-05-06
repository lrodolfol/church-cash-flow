using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers;
using Registration.Mapper.DTOs.ChurchAddress;

namespace Registration.API.Controllers;

[ApiController]
public class ChurchController : ControllerBase
{
    private readonly ChurchHandler _handler;
    private readonly CViewModel? _viewModel;

    public ChurchController(ChurchHandler handler)
    {
        _handler = handler;
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("/api/v1/church")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("/api/v1/church/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpGet("/api/v1/church/{churchId:int}/members")]
    [Authorize(Roles = "MINISTERIO,LOCAL")]
    public async Task<IActionResult> GetMembers([FromServices] IMemberRepository memberContext, [FromRoute] int churchId)
    {
        var resultViewModel = await _handler.GetMembers(memberContext, churchId);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPost("/api/v1/church")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> PostChurch([FromBody] ChurchAddress churchAddress)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Create(churchAddress);
        
        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPut("/api/v1/church/{id:int}")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> PutChurch([FromBody] ChurchAddress churchAddress, [FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Update(churchAddress, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpDelete("/api/v1/church/{id:int}")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> DeleteChurch(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

}