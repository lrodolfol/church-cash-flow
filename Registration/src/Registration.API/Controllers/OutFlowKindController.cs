using Registration.Handlers.Handlers;
using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.OutFlowKind;
using Microsoft.AspNetCore.Authorization;

namespace Registration.API.Controllers;
public class OutFlowKindController : ControllerBase
{
    public readonly OutFlowKindHandler _handler;
    private readonly CViewModel _viewModel;

    public OutFlowKindController(OutFlowKindHandler handler)
    {
        _handler = handler;
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("api/v1/outflow-kind")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("api/v1/outflow-kind/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpPost("api/v1/outflow-kind")]
    public async Task<IActionResult> Create([FromBody] EditOutFlowKindDto outFlowKindDto)
    {
        if (!ModelState.IsValid)
        {
            _viewModel.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Create(outFlowKindDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpDelete("/api/v1/outflow-kind/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}
