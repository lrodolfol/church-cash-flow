using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Mapper.DTOs.OutFlowKind;

namespace Registration.API.Controllers;
public class OutFlowKindController : ControllerBase
{
    public readonly IHandler<ReadOutFlowKindDto,EditOutFlowKindDto> _handler;

    public OutFlowKindController(IHandler<ReadOutFlowKindDto, EditOutFlowKindDto> handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/outflow-kind")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpGet("api/v1/outflow-kind/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPost("api/v1/outflow-kind")]
    public async Task<IActionResult> Create([FromBody] EditOutFlowKindDto outFlowKindDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(outFlowKindDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpDelete("/api/v1/outflow-kind/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}
