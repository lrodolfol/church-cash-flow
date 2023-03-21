using ChurchCashFlow.Data.ViewModels.Dtos.Post;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Handlers;
using Microsoft.AspNetCore.Mvc;
using ChurchCashFlow.Data.ViewModels.Dtos.MeetingKind;

namespace ChurchCashFlow.Controllers;
public class MeetingKindController : ControllerBase
{
    public readonly MeetingKindHandler _handler;
    private string _routeName = "meeting-kind";

    public MeetingKindController(MeetingKindHandler handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/meeting-kind")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("api/v1/meeting-kind/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPost("api/v1/meeting-kind")]
    public async Task<IActionResult> Create([FromBody] EditMeetingKindDto meetingKindDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(meetingKindDto);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpDelete("/api/v1/meeting-kind/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }
}
