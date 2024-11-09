using Microsoft.AspNetCore.Mvc;
using Registration.DomainBase.Entities.Operations.RequestsControllers;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Operations;

namespace Registration.API.Controllers.Operations;

public class ReportsController : ControllerBase
{
    private readonly CViewModel _viewModel;
    private readonly ReportsHandlers _handler;

    public ReportsController(CViewModel? viewModel, ReportsHandlers handler)
    {
        _viewModel = viewModel!;
        _handler = handler!;
    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpGet("/api/v1/tithers")]
    public async Task<IActionResult> Tithers([FromBody] TithersRequest tithers)
    {
        var resultViewModel = await _handler.TithersReportAsync(tithers);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
        
    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpGet("/api/v1/offers")]
    public async Task<IActionResult> Offers([FromBody] OfferingRequest offering)
    {
        var resultViewModel = await _handler.OfferingReportAsync(offering);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);

    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpGet("/api/v1/fruiters")]
    public async Task<IActionResult> Fruiters([FromBody] FirstFruitsRequest offering)
    {
        var resultViewModel = await _handler.FirstFruitsReportAsync(offering);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);

    }

    [Authorize(Roles = "M-TRS, L-TRS")]
    [HttpGet("/api/v1/monthly-closing")]
    public async Task<IActionResult> MonthlyClosing([FromBody] EditMonthWorkDto dto)
    {
        var resultViewModel = await _handler.MonthlyClosingReportAsync(dto);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);

    }
}
