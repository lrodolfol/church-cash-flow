using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Microsoft.AspNetCore.Authorization;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.FirstFruits;

namespace Registration.API.Controllers.Registrations;

[ApiController]
public class FirstFruitsController : ControllerBase
{
    private readonly FirstFruitsHanler _handler;
    private readonly CViewModel? _viewModel;

    public FirstFruitsController(FirstFruitsHanler handler)
    {
        _handler = handler;
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/first-fruits/all/{churchId:int}")]
    public async Task<IActionResult> GetAll([FromRoute] int churchId, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(churchId, active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/first-fruits/all/{churchId:int}/{yearMonth:int}")]
    public async Task<IActionResult> GetAllByCompetence([FromRoute] int churchId, [FromRoute] int yearMonth, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAllByCompetence(churchId, yearMonth.ToString(), active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/first-fruits/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpPost("api/v1/first-fruits")]
    public async Task<IActionResult> Create([FromBody] EditFirstFruitsDto firstFruitsDto)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Create(firstFruitsDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpPut("api/v1/first-fruits/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditFirstFruitsDto firstFruitsDto, int id)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Update(firstFruitsDto, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpDelete("/api/v1/first-fruits/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}
