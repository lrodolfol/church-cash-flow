using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Handlers;
using Microsoft.AspNetCore.Mvc;
using ChurchCashFlow.Data.ViewModels.Dtos.MeetingKind;
using ChurchCashFlow.Data.ViewModels.Dtos.OfferingKind;

namespace ChurchCashFlow.Controllers;
public class OfferingKindController : ControllerBase
{
    public readonly OfferingKindHandler _handler;
    private string _routeName = "offering-kind";

    public OfferingKindController(OfferingKindHandler handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/offering-kind")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("api/v1/offering-kind/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPost("api/v1/offering-kind")]
    public async Task<IActionResult> Create([FromBody] EditOfferingKindDto offeringKindDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(offeringKindDto);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpDelete("/api/v1/offering-kind/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }
}
