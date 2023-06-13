using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainCore.InterfaceRepository;
using Registration.Resources;
using Dapper;

namespace Registration.Repository.Repository.Operations;

public class MysqlMonthlyClosingRepository : MysqlBase, IMonthlyClosingDataBase
{
    public MysqlMonthlyClosingRepository(IConfiguration configuration):base(configuration)
    {
    }

    private async Task<IEnumerable<MonthlyClosing>> ExecuteQuery(string query)
    {
        var obj = await _mysqlConnection.QueryAsync<MonthlyClosing>(query);

        return obj;
    }

    private string ReadQueryMonthClosing(string churcId, string month, string year, Func<string, string, string, string> method) => method(churcId, month, year);


    public async Task<List<MonthlyClosing>> SelectReportAsync(string churchId, string month, string year)
    {
        var outFlow = await ExecuteQuery(
            ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingOutFlow)
            );

        var tithes = await ExecuteQuery(
            ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingTithes)
            );

        var offering = await ExecuteQuery(
            ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingOffering)
            );

        var fruits = await ExecuteQuery(
            ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingFirstFruits)
            );

        List<MonthlyClosing> unionObjects = new[] { outFlow, tithes, offering, fruits }
        .SelectMany(x => x).ToList();

        return unionObjects;
    }
}