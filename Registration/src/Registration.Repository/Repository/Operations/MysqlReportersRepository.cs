using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainBase.Entities.Operations.RequestsControllers;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.InterfaceRepository;
using Registration.Mapper.DTOs.Registration.MonthWork;
using Registration.Resources;
using System;

namespace Registration.Repository.Repository.Operations;

public class MysqlReportersRepository : MysqlBase, IReportsDataBase
{
    public MysqlReportersRepository(IConfiguration configuration) : base(configuration)
    {
    }

    public async Task<IEnumerable<MonthlyTithers>> SelectTitherByChurch(TithersRequest tithers)
    {           
        var year = tithers.YearMonth!.Substring(0, 4);
        var month = tithers.YearMonth!.Substring(4, 2);
        
        var tithePlayers = await ExecuteQuery(
            ReadQueryTithers(tithers.ChurchId.ToString(), month, year, ReadQueries.MonthlyTithers)
            );

        return tithePlayers;
    }

    private string ReadQueryTithers(string churcId, string month, string year, Func<string, string, string, string> method) => method(churcId, month, year);

    private async Task<IEnumerable<MonthlyTithers>> ExecuteQuery(string query)
    {
        var obj = await _mysqlConnection.QueryAsync<MonthlyTithers>(query);

        return obj;
    }
}