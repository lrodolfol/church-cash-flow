using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Handlers;
using Microsoft.AspNetCore.Mvc;
using ChurchCashFlow.Data.ViewModels.Dtos.OutFlowKind;

namespace ChurchCashFlow.Controllers;
public class OutFlowKindController : ControllerBase
{
    public readonly OutFlowKindHandler _handler;

    public OutFlowKindController(OutFlowKindHandler handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/outflow-kind")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("api/v1/outflow-kind/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPost("api/v1/outflow-kind")]
    public async Task<IActionResult> Create([FromBody] EditOutFlowKindDto outFlowKindDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(outFlowKindDto);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpDelete("/api/v1/outflow-kind/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }
}
