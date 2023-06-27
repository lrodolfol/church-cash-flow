using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities.ChurchSystem;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainBase.Entities.Operations.RequestsControllers;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Repository.Repository.Operations;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers.Operations;

public class ReportsHandlers : BaseOpersHandler
{
    private readonly IReportsDataBase _database;
    private readonly IConfiguration _configuration;

    public ReportsHandlers(CViewModel viewModel, IConfiguration configuration) : base(viewModel)
    {
        _configuration = configuration;
        _database = new MysqlReportersRepository(_configuration);
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

}
