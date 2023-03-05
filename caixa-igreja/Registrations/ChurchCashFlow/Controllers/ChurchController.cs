using ChurchCashFlow.Extensions;
using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ChurchCashFlow.Handlers;

namespace ChurchCashFlow.Controllers;

[ApiController]
public class ChurchController : ControllerBase
{
    private readonly ChurchHandler _handler;

    public ChurchController(ChurchHandler handler)
    {
        _handler = handler;
    }

    [HttpGet("/api/v1/church")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("/api/v1/church/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPost]
    [Route("/api/v1/church")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> PostChurch([FromBody] ChurchAddress churchAddress)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(churchAddress);
        
        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPut]
    [Route("/api/v1/church/{id:int}")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> PutChurch([FromBody] ChurchAddress churchAddress, [FromRoute] int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(churchAddress, id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpDelete]
    [Route("/api/v1/church/{id:int}")]
    [Authorize(Roles = "MINISTERIO")]
    public async Task<IActionResult> DeleteChurch(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

}