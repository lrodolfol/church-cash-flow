using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Data.ViewModels.Dtos.Member;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace ChurchCashFlow.Controllers;
public class MemberController : ControllerBase
{
    private readonly MemberHandler _handler;

    public MemberController(MemberHandler handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/member")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("api/v1/member/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("api/v1/member/{code}")]
    public async Task<IActionResult> GetByCode([FromRoute] string code)
    {
        var resultViewModel = await _handler.GetByCode(code.ToString());

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPost("api/v1/member")]
    public async Task<IActionResult> Create([FromBody] EditMemberDto memberEditDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(memberEditDto);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPut("api/v1/member/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditMemberDto memberEditDto, int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(memberEditDto, id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpDelete("/api/v1/member/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }
}
