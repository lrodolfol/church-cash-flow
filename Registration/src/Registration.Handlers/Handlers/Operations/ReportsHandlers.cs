using AutoMapper;
using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities.ChurchSystem;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainBase.Entities.Operations.RequestsControllers;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Repository.Repository.Operations;

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

    public async Task<string> TithersReportAsync(TithersRequest tithers)
    {
        var tithePlayers = await _database.SelectTitherByChurch(tithers);

        var jsonObj = new JsonStringResult<IEnumerable<MonthlyTithers>>(tithePlayers);
        var jsonStr = jsonObj.ToString();

        return jsonStr;
    }

}
