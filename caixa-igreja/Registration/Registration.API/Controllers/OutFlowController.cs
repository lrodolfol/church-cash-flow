using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Mapper.DTOs.Church;
using Registration.Mapper.DTOs.OutFlow;

namespace Registration.API.Controllers;

[ApiController]
public class OutFlowController : ControllerBase
{
    private readonly IHandlerByChurch<ReadOutFlowDto, EditOutFlowDto> _handler;

    public OutFlowController(IHandlerByChurch<ReadOutFlowDto, EditOutFlowDto> handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/out-flow/all/{churchId:int}")]
    public async Task<IActionResult> GetAll([FromRoute] int churchId, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(churchId, active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpGet("api/v1/out-flow/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPost("api/v1/out-flow")]
    public async Task<IActionResult> Create([FromBody] EditOutFlowDto outFlowEditDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(outFlowEditDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPut("api/v1/out-flow/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditOutFlowDto userEditDto, int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(userEditDto, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpDelete("/api/v1/out-flow/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}
