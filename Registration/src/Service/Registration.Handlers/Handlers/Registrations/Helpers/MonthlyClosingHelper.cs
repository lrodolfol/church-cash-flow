using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ServicesAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Registration.MonthWork;
using System.Text.Json;
using Serilog;
using System.Collections.Generic;

namespace Registration.Handlers.Handlers.Registrations.Helpers;
internal class MonthlyClosingHelper
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger _logger;
    private readonly IMonthlyClosingDataBase _monthlyClosingRepository;
    private readonly ICacheService _cache;
    private string _competence;

    public MonthlyClosingHelper(IServiceProvider serviceProvider, string competence)
    {
        _serviceProvider = serviceProvider;

        _cache = _serviceProvider.GetRequiredService<ICacheService>();
        _logger = _serviceProvider.GetRequiredService<ILogger>();
        _monthlyClosingRepository = _serviceProvider.GetRequiredService<IMonthlyClosingDataBase>();
        _competence = competence;
    }

    public async Task SetCachingAsync(EditMonthWorkDto editMonthYorkDto, ReadMonthWorkDto readMonthWork)
    {
        var strReadMonthWork = JsonSerializer.Serialize(readMonthWork);
        await _cache.SetStringAsync($"{"MonthWork"}-{editMonthYorkDto.YearMonth}-church-{editMonthYorkDto.ChurchId}", strReadMonthWork);
    }

    public async Task<(bool success, List<string> messages)> CallRecord(EditMonthWorkDto editMonthYorkDto)
    {
        try
        {
            //_mysqlDataBase = new MysqlMonthlyClosingRepository(_configuration);
            var report = new Report(_monthlyClosingRepository, editMonthYorkDto.ChurchId, _competence);
            var jsonReport = await report.Generate();

            if (jsonReport != null)
                return (true, []);
        }
        catch (MySqlException ex)
        {
            _logger.Error("(ER-OPH01) Error with database. {error}", ex.Message);
            return SetErrorsReport(ex.Message);
        }
        catch (InvalidDataException ex)
        {
            _logger.Error("(ER-OPH02) Error with properties. Check the churchId and competence {error}", ex);
            return SetErrorsReport(ex.Message);
        }
        catch (Exception ex)
        {
            _logger.Error("(ER-OPH03) Error during generation the report {error}", ex);
            return SetErrorsReport(ex.Message);
        }

        throw new Exception("Falha na geração de relatorio");

        (bool, List<string>) SetErrorsReport(string errorStr)
        {
            _logger.Warning("Month was blocked, but it not possible generate the report.");

            return (false, new List<string> { "Month was blocked, but it not possible generate the report.", errorStr });
        }
    }

    public void SendToMessageBroker(int churchId, string competence)
    {
        return;

        //var blockMonthWorkMessage = new BlockMonthWorkMessage(_configuration, churchId, competence);
        //blockMonthWorkMessage.PreparePublish();
    }
}
