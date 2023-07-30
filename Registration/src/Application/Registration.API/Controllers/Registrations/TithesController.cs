using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Microsoft.AspNetCore.Authorization;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.Tithes;

namespace Registration.API.Controllers.Registrations;

[ApiController]
public class TithesController : ControllerBase
{
    private readonly TithesHanler _handler;
    private readonly CViewModel? _viewModel;

    public TithesController(TithesHanler handler)
    {
        _handler = handler;
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/tithes/all/{churchId:int}")]
    public async Task<IActionResult> GetAll([FromRoute] int churchId, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(churchId, active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/tithes/all/{churchId:int}/{yearMonth:int}")]
    public async Task<IActionResult> GetAllByCompetence([FromRoute] int churchId, [FromRoute] int yearMonth, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAllByCompetence(churchId, yearMonth.ToString(), active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/tithes/period/{churchId:int}/")]
    public async Task<IActionResult> GetByPeriod([FromRoute] int churchId, [FromQuery] string initialDate, [FromQuery] string finalDate, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetByPeriod(churchId, initialDate, finalDate, active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/tithes/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/tithes/{churchId}/{id:int}")]
    public async Task<IActionResult> GetOneByChurch([FromRoute] int churchId, [FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOneByChurch(churchId, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpPost("api/v1/tithes")]
    public async Task<IActionResult> Create([FromBody] EditTithesDto tithesEditDto)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Create(tithesEditDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpPut("api/v1/tithes/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditTithesDto tithesEditDto, int id)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Update(tithesEditDto, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpDelete("/api/v1/tithes/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

}
