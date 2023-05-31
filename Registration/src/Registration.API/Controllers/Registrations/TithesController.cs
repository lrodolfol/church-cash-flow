using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Tithes;
using Microsoft.AspNetCore.Authorization;
using Registration.Handlers.Handlers.Registrations;

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

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("api/v1/tithes/all/{churchId:int}")]
    public async Task<IActionResult> GetAll([FromRoute] int churchId, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(churchId, active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("api/v1/tithes/all/{churchId:int}/{competence}")]
    public async Task<IActionResult> GetAllByCompetence([FromRoute] int churchId, [FromRoute] string competence, [FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAllByCompetence(churchId, competence, active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("api/v1/tithes/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
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

    [Authorize(Roles = "MINISTERIO,LOCAL")]
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

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpDelete("/api/v1/tithes/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

}
