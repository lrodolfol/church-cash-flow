﻿using Registration.Handlers.Handlers;
using Microsoft.AspNetCore.Mvc;
using Registration.API.Extensions;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.OfferingKind;

namespace Registration.API.Controllers;
public class OfferingKindController : ControllerBase
{
    public readonly OfferingKindHandler _handler;
    private readonly CViewModel _viewModel;

    public OfferingKindController(OfferingKindHandler handler)
    {
        _handler = handler;
    }

    [HttpGet("api/v1/offering-kind")]
    public async Task<IActionResult> GetAll([FromQuery] bool active = true)
    {
        var resultViewModel = await _handler.GetAll(active);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpGet("api/v1/offering-kind/{id:int}")]
    public async Task<IActionResult> GetOne([FromRoute] int id)
    {
        var resultViewModel = await _handler.GetOne(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpPost("api/v1/offering-kind")]
    public async Task<IActionResult> Create([FromBody] EditOfferingKindDto offeringKindDto)
    {
        if (!ModelState.IsValid)
        {
            _viewModel.SetErrors(ModelState.GetErrors());
            return BadRequest(_viewModel);
        }

        var resultViewModel = await _handler.Create(offeringKindDto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }

    [HttpDelete("/api/v1/offering-kind/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var resultViewModel = await _handler.Delete(id);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
    }
}
