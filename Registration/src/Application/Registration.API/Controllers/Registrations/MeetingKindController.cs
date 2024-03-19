using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Microsoft.AspNetCore.Authorization;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.MeetingKind;
using Registration.Handlers.ViewModel;

namespace Registration.API.Controllers.Registrations;
public class MeetingKindController : ControllerBase
{
    public readonly MeetingKindHandler _handler;
    private readonly CViewModel? _viewModel;

    public MeetingKindController(MeetingKindHandler handler)
    {
        _handler = handler;
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/meeting-kind")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/meeting-kind/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT")]
    [HttpPost("api/v1/meeting-kind")]
    public async Task<IActionResult> Create([FromBody] EditMeetingKindDto meetingKindDto)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Create(meetingKindDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT")]
    [HttpDelete("/api/v1/meeting-kind/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpPut("/api/v1/meeting-kind/{id:int}")]
    public async Task<IActionResult> Update(int id)
    {
        var resultViewModel = new ResultViewModel();
        resultViewModel.SetErrors("Não é possivel atualizar tipode culto. Faça um novo cadastro e exclua o anterior");

        return StatusCode(200, resultViewModel);
    }
}
