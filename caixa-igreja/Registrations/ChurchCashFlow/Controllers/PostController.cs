using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Extensions;
using ChurchCashFlow.Handlers;
using Microsoft.AspNetCore.Mvc;
using ChurchCashFlow.Data.ViewModels.Dtos.Post;

namespace ChurchCashFlow.Controllers;

[ApiController]
public class PostController : ControllerBase
{
    private readonly PostHandler _handler;

    public PostController(PostHandler handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/post")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpGet("api/v1/post/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPost("api/v1/post")]
    public async Task<IActionResult> Create([FromBody] EditPostDto postEditDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(postEditDto);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpPut("api/v1/post/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditPostDto postEditDto, int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(postEditDto, id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }

    [HttpDelete("/api/v1/post/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.StatusCode, resultViewModel);
    }
}