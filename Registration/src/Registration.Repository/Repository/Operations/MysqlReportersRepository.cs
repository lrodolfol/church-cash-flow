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


    private string ReadQueryMonthlyByChurch(string churcId, string month, string year, 
        Func<string, string, string, string> method) => method(churcId, month, year);


    public async Task<IEnumerable<MonthlyTithers>> SelectTitherByChurch(TithersRequest tithers)
    {           
        var year = tithers.YearMonth!.Substring(0, 4);
        var month = tithers.YearMonth!.Substring(4, 2);
        
        var tithePlayers = await ExecuteQueryTithers(
            ReadQueryMonthlyByChurch(tithers.ChurchId.ToString(), month, year, ReadQueries.MonthlyTithers)
            );

        return tithePlayers;
    }
    public async Task<IEnumerable<MonthlyOffers>> SelectOfferingByChurch(OfferingRequest offering)
    {
        var year = offering.YearMonth!.Substring(0, 4);
        var month = offering.YearMonth!.Substring(4, 2);

        var offerings = await ExecuteQueryOffering(
            ReadQueryMonthlyByChurch(offering.ChurchId.ToString(), month, year, ReadQueries.MonthlyOffering)
            );

        return offerings;
    }
    public async Task<IEnumerable<MonthlyFruiters>> SelectFirstFruitsByChurch(FirstFruitsRequest fruits)
    {
        var year = fruits.YearMonth!.Substring(0, 4);
        var month = fruits.YearMonth!.Substring(4, 2);

        var offerings = await ExecuteQueryFirstFruits(
            ReadQueryMonthlyByChurch(fruits.ChurchId.ToString(), month, year, ReadQueries.MonthlyFirstFruits)
            );

        return offerings;
    }









    private async Task<IEnumerable<MonthlyFruiters>> ExecuteQueryFirstFruits(string query)
    {
        var obj = await _mysqlConnection.QueryAsync<MonthlyFruiters>(query);

        return obj;
    }
    private async Task<IEnumerable<MonthlyTithers>> ExecuteQueryTithers(string query)
    {
        var obj = await _mysqlConnection.QueryAsync<MonthlyTithers>(query);

        return obj;
    }
    private async Task<IEnumerable<MonthlyOffers>> ExecuteQueryOffering(string query)
    {
        var obj = await _mysqlConnection.QueryAsync<MonthlyOffers>(query);

        return obj;
    }
}