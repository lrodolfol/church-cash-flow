using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Mapper.DTOs.Church;
using Registration.Mapper.DTOs.ChurchAddress;

namespace Registration.API.Controllers;

[ApiController]
public class ChurchController : ControllerBase
{
    private readonly IHandlerChurch<ReadChurchDto, ChurchAddress> _handler;

    public ChurchController(IHandlerChurch<ReadChurchDto, ChurchAddress> handler)
    {
        _handler = handler;
    }

    [HttpGet("/api/v1/church")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpGet("/api/v1/church/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpGet("/api/v1/church/{churchId:int}/members")]
    public async Task<IActionResult> GetMembers([FromServices] IMemberRepository memberContext, [FromRoute] int churchId)
    {
        var resultViewModel = await _handler.GetMembers(memberContext, churchId);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPost]
    [Route("/api/v1/church")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> PostChurch([FromBody] ChurchAddress churchAddress)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(churchAddress);
        
        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPut]
    [Route("/api/v1/church/{id:int}")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> PutChurch([FromBody] ChurchAddress churchAddress, [FromRoute] int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(churchAddress, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpDelete]
    [Route("/api/v1/church/{id:int}")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> DeleteChurch(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

}