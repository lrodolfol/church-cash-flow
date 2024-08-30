using Microsoft.AspNetCore.Mvc;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.API.Extensions;
using Microsoft.AspNetCore.Authorization;
using Registration.Handlers.Handlers.Registrations;
using ILogger = Serilog.ILogger;
using Registration.Mapper.DTOs.Registration.MonthWork;

namespace Registration.API.Controllers.Operations;
public class MonthlyClosingController : ControllerBase
{
    private readonly OperationsHandler _handler;
    private readonly CViewModel? _viewModel;
    private readonly ILogger _logger;

    public MonthlyClosingController(OperationsHandler handler, CViewModel viewModel, ILogger logger)
    {
        _handler = handler;
        _viewModel = viewModel;
        _logger = logger;
    }

    [Authorize(Roles = "M-SCT, M-TRS")]
    [HttpPost("/api/v1/monthly-closing")]
    public async Task<IActionResult> BlockMonth([FromBody] EditMonthWorkDto editMonthWorkDto)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest();
        }

        var resultViewModel = await _handler.BlockMonthWork(editMonthWorkDto);

        return StatusCode(_handler.GetStatusCode(), _viewModel);
    }

    [Authorize(Roles = "M-SCT, M-TRS")]
    [HttpDelete("/api/v1/monthly-closing/{id:int}")]
    public async Task<IActionResult> UnblockMonth([FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest();
        }

        var resultViewModel = await _handler.UnblockMonthWork(id);

        return StatusCode(_handler.GetStatusCode(), _viewModel);
    }

    [Authorize(Roles = "L-SCT, M-SCT, M-TRS, L-TRS")]
    [HttpGet("/api/v1/monthly-closing/{churchId:int}")]
    public async Task<IActionResult> MonthWorkAll([FromRoute] int churchId)
    {
        if (!ModelState.IsValid)
        {
            _viewModel!.SetErrors(ModelState.GetErrors());
            return BadRequest();
        }

        var resultViewModel = await _handler.GetAll(churchId);

        return StatusCode(_handler.GetStatusCode(), _viewModel);
    }
}