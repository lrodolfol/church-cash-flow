using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainCore.InterfaceRepository;
using Registration.Resources;
using Dapper;
using System.Text;

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

    private string ReadQueryMonthClosing(string churcId, string month, string year, Func<string, string, string, string> method) 
        => method(churcId, month, year);

    public async Task<List<MonthlyClosing>> SelectReportAsync(string churchId, string month, string year)
    {
        var builder = new StringBuilder();  
        builder.Append(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyValueMonthMinus1).Replace("\r\n",""));
        builder.Append(" UNION ALL ");
        builder.Append(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingOutFlow).Replace("\r\n",""));
        builder.Append(" UNION ALL ");
        builder.Append(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingTithes).Replace("\r\n", ""));
        builder.Append(" UNION ALL ");
        builder.Append(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingOffering).Replace("\r\n", ""));
        builder.Append(" UNION ALL ");
        builder.Append(ReadQueryMonthClosing(churchId, month, year, ReadQueries.MonthlyClosingFirstFruits).Replace("\r\n", ""));

        var objects = (await ExecuteQuery(builder.ToString())).ToList();

        return objects;
    }
}