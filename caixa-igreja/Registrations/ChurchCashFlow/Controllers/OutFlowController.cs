using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Handlers;
using Microsoft.AspNetCore.Mvc;
using ChurchCashFlow.Data.ViewModels.Dtos.OutFlow;
using ChurchCashFlow.Data.ViewModels.Dtos.User;

namespace ChurchCashFlow.Controllers;

[ApiController]
public class OutFlowController : ControllerBase
{
    private readonly OutFlowHanler _handler;

    public OutFlowController(OutFlowHanler handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/out-flow/all/{churchId:int}")]
    public async Task<IActionResult> GetAll([FromRoute] int churchId, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(churchId, active);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("api/v1/out-flow/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPost("api/v1/out-flow")]
    public async Task<IActionResult> Create([FromBody] EditOutFlowDto outFlowEditDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(outFlowEditDto);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPut("api/v1/out-flow/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditOutFlowDto userEditDto, int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(userEditDto, id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpDelete("/api/v1/out-flow/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }
}
