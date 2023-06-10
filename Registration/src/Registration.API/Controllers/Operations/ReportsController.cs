using Microsoft.AspNetCore.Mvc;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainBase.Entities.Operations.RequestsControllers;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Operations;
using System;

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


    [HttpGet("/api/v1/tithers")]
    public async Task<IActionResult> Tithers([FromBody] TithersRequest tithers)
    {
        var resultViewModel = await _handler.TithersReportAsync(tithers);

        return StatusCode(_handler.GetStatusCode(), resultViewModel);
        
    }
}
