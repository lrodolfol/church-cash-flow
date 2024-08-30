using Entitie = ConsumerChurchMonthWork.Entitie;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ConsumerChurchMonthWork.Repository.Queries;

namespace ConsumerChurchMonthWork.Repository.Connections;

public class MysqlDataBase : IDataBase
{
    private readonly IConfiguration _configuration;
    private MySqlConnection _mysqlConnection;

    public MysqlDataBase(IConfiguration configuration)
    {
        _configuration = configuration;

        var conStr = _configuration.GetConnectionString("DataConnection");

        _mysqlConnection = new MySqlConnection(conStr);
    }

    private async Task<IEnumerable<Entitie.MonthlyClosing>> ExecuteQuery(string query)
    {
        var obj = await _mysqlConnection.QueryAsync<Entitie.MonthlyClosing>(query);

        return obj;
    }


    private string ReadQueryMonthClosing(string churcId, string month, string year, Func<string, string, string, string> method) => method(churcId, month, year);


    public async Task<List<Entitie.MonthlyClosing>> SelectReport(string churchId, string month, string year)
    {
        var outFlow = await ExecuteQuery(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingOutFlow));
        var tithes = await ExecuteQuery(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingTithes));
        var offering = await ExecuteQuery(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingOffering));
        var fruits = await ExecuteQuery(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingFirstFruits));

        List<Entitie.MonthlyClosing> unionObjects = new[] { outFlow, tithes, offering, fruits }.SelectMany(x => x).ToList();

        return unionObjects;
    }

}
