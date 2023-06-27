using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Microsoft.AspNetCore.Authorization;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.Member;

namespace Registration.API.Controllers.Registrations;
public class MemberController : ControllerBase
{
    private readonly MemberHandler _handler;
    private readonly CViewModel? _viewModel;

    public MemberController(MemberHandler handler)
    {
        _handler = handler;
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/member")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/member/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("api/v1/member/{code}")]
    public async Task<IActionResult> GetByCode([FromRoute] string code)
    {
        var resultViewModel = await _handler.GetByCode(code.ToString());

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT")]
    [HttpPost("api/v1/member")]
    public async Task<IActionResult> Create([FromBody] EditMemberDto memberEditDto)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Create(memberEditDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT")]
    [HttpPut("api/v1/member/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditMemberDto memberEditDto, int id)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Update(memberEditDto, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT")]
    [HttpDelete("/api/v1/member/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}
