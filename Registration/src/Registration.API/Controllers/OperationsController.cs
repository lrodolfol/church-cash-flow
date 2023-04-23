using Registration.Handlers.Handlers;
using Microsoft.AspNetCore.Mvc;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Offering;
using Registration.API.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace Registration.API.Controllers;
public class OperationsController : ControllerBase
{
    private readonly OperationsHandler _handler;
    private readonly CViewModel _viewModel;

    public OperationsController(OperationsHandler handler, CViewModel viewModel)
    {
        _handler = handler;
        _viewModel = viewModel;
    }

    [Authorize(Roles = "MINISTERIO")]
    [HttpPost("/api/v1/operations/block-month")]
    public async Task<IActionResult> BlockMonth([FromBody] EditMonthWorkDto editMonthWorkDto)
    {
        if (!ModelState.IsValid)
        {
            _viewModel.SetErrors(ModelState.GetErrors());
            return BadRequest();
        }

        var resultViewModel = await _handler.BlockMonthWork(editMonthWorkDto);

        return StatusCode(_handler.GetStatusCode(), _viewModel);
    }

    [Authorize(Roles = "MINISTERIO")]
    [HttpDelete("/api/v1/operations/unblock-month/{id:int}")]
    public async Task<IActionResult> UnblockMonth([FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            _viewModel.SetErrors(ModelState.GetErrors());
            return BadRequest();
        }

        var resultViewModel = await _handler.UnblockMonthWork(id);

        return StatusCode(_handler.GetStatusCode(), _viewModel);
    }

    [Authorize(Roles = "MINISTERIO,LOCAL")]
    [HttpGet("/api/v1/operations/month-work/{churchId:int}")]
    public async Task<IActionResult> MonthWorkAll([FromRoute] int churchId)
    {
        if (!ModelState.IsValid)
        {
            _viewModel.SetErrors(ModelState.GetErrors());
            return BadRequest();
        }

        var resultViewModel = await _handler.GetAll(churchId);

        return StatusCode(_handler.GetStatusCode(), _viewModel);
    }
}