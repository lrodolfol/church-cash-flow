using CRegistration.Mapper.DTOs.Post;
using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Mapper.DTOs.Post;

namespace Registration.API.Controllers;

[ApiController]
public class PostController : ControllerBase
{
    private readonly IHandler<ReadPostDto, EditPostDto> _handler;

    public PostController(IHandler<ReadPostDto, EditPostDto> handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/post")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpGet("api/v1/post/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPost("api/v1/post")]
    public async Task<IActionResult> Create([FromBody] EditPostDto postEditDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Create(postEditDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPut("api/v1/post/{id:int}")]
    public async Task<IActionResult> Update([FromBody] EditPostDto postEditDto, int id)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var resultViewModel = await _handler.Update(postEditDto, id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpDelete("/api/v1/post/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}