using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainCore.InterfaceRepository;
using Registration.Resources;
using Dapper;

namespace Registration.Repository;

public class MysqlDataBase : IDataBase
{
    private readonly IConfiguration _configuration;
    private MySqlConnection _mysqlConnection;

    public MysqlDataBase(IConfiguration configuration)
    {
        _configuration = configuration;

        var conStr = _configuration.GetConnectionString("DefaultConnectionMySQL");

        _mysqlConnection = new MySqlConnection(conStr);
    }

    private async Task<IEnumerable<MonthlyClosing>> ExecuteQuery(string query)
    {
        var obj = await _mysqlConnection.QueryAsync<MonthlyClosing>(query);

        return obj;
    }


    private string ReadQueryMonthClosing(string churcId, string month, string year, Func<string, string, string, string> method) => method(churcId, month, year);


    public async Task<List<MonthlyClosing>> SelectReport(string churchId, string month, string year)
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