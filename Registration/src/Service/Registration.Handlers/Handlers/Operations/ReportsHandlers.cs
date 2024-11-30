using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Registration.DomainBase.Entities.ChurchSystem;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainBase.Entities.Operations.RequestsControllers;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ServicesAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations.Helpers;
using Registration.Mapper.DTOs.Registration.MonthWork;
using Registration.Repository.Repository.Operations;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers.Operations;

public class ReportsHandlers : BaseOpersHandler
{
    private readonly IReportsDataBase _database;
    private readonly IConfiguration _configuration;
    private readonly IServiceProvider _serviceProvider;

    public ReportsHandlers(CViewModel viewModel, IConfiguration configuration, IServiceProvider serviceProvider) : base(viewModel)
    {
        _configuration = configuration;
        _database = new MysqlReportersRepository(_configuration);
        _serviceProvider = serviceProvider;
    }

    public async Task<CViewModel> TithersReportAsync(TithersRequest tithers)
    {
        try
        {
            var tithePlayers = await _database.SelectTitherByChurch(tithers);

            var jsonObj = new JsonStringResult<IEnumerable<MonthlyTithers>>(tithePlayers);
            var jsonStr = jsonObj.ToString();

            _viewModel.SetData(jsonStr);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - RPT1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> FirstFruitsReportAsync(FirstFruitsRequest fruits)
    {
        try
        {
            var tithePlayers = await _database.SelectFirstFruitsByChurch(fruits);

            var jsonObj = new JsonStringResult<IEnumerable<MonthlyFruiters>>(tithePlayers);
            var jsonStr = jsonObj.ToString();

            _viewModel.SetData(jsonStr);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - RPT1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> OfferingReportAsync(OfferingRequest offering)
    {
        try
        {
            var offeringPlayers = await _database.SelectOfferingByChurch(offering);

            var jsonObj = new JsonStringResult<IEnumerable<MonthlyOffers>>(offeringPlayers);
            var jsonStr = jsonObj.ToString();

            _viewModel.SetData(jsonStr);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - RPT1102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> MonthlyClosingReportAsync(EditMonthWorkDto editMonthYorkDto)
    {
        var cache = _serviceProvider.GetRequiredService<ICacheService>();

        var value = await cache.GetStringAsync($"{"MonthWork"}-{editMonthYorkDto.YearMonth}-church-{editMonthYorkDto.ChurchId}");

        if (!string.IsNullOrEmpty(value))
        {
            _viewModel.SetData(value);
            return _viewModel;
        }

        var competence = editMonthYorkDto.YearMonth.ToString().Substring(0, 4) + "-" +
            editMonthYorkDto.YearMonth.ToString().Substring(4, editMonthYorkDto.YearMonth.ToString().Length - 4) + "-" + "01";

        var helper = new MonthlyClosingHelper(_serviceProvider);
        (bool Success, IEnumerable<MonthlyClosing> JsonFile, List<string> Messages) returnTuple 
            = helper.CallRecord(editMonthYorkDto, competence).Result;

        await helper.SetCachingAsync(editMonthYorkDto, returnTuple.JsonFile);

        if (!returnTuple.Success)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors(returnTuple.Messages);
        }
        else
        {
            _viewModel.SetData(returnTuple.JsonFile);
            _statusCode = (int)Scode.CREATED;
        }

        return _viewModel;
    }
}
