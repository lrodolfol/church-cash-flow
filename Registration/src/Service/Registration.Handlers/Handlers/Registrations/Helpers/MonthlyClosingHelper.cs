using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ServicesAbstraction;
using Registration.Mapper.DTOs.Registration.MonthWork;
using System.Text.Json;
using Serilog;
using Registration.DomainBase.Entities.Operations;
using MessageBroker.Messages;
using Registration.DomainCore.Events;

namespace Registration.Handlers.Handlers.Registrations.Helpers;
internal class MonthlyClosingHelper
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger _logger;
    private readonly IMonthlyClosingDataBase _monthlyClosingRepository;
    private readonly ICacheService _cache;

    public MonthlyClosingHelper(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;

        _cache = _serviceProvider.GetRequiredService<ICacheService>();
        _logger = _serviceProvider.GetRequiredService<ILogger>();
        _monthlyClosingRepository = _serviceProvider.GetRequiredService<IMonthlyClosingDataBase>();
    }

    public async Task SetCachingAsync(EditMonthWorkDto editMonthYorkDto, IEnumerable<MonthlyClosing> monthlyClosing)
    {
        var strReadMonthlyClosing = JsonSerializer.Serialize(monthlyClosing);
        await _cache.SetStringAsync($"{"MonthWork"}-{editMonthYorkDto.YearMonth}-church-{editMonthYorkDto.ChurchId}", strReadMonthlyClosing);
    }

    public async Task UnsetCachingAsync(int yearMonth, int churchId)
    {
        await _cache.UnsetStringAsync($"{"MonthWork"}-{yearMonth}-church-{churchId}");
    }

    public async Task<(bool success, IEnumerable<MonthlyClosing> JsonFile, List<string> Messages)> CallRecord(EditMonthWorkDto editMonthYorkDto, string competence)
    {
        try
        {
            //_mysqlDataBase = new MysqlMonthlyClosingRepository(_configuration);
            var report = new Report(_monthlyClosingRepository, editMonthYorkDto.ChurchId, competence);
            IEnumerable<MonthlyClosing>? jsonReport = await report.Generate();

            if (jsonReport != null)
                return (true, jsonReport, []);
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

        (bool, IEnumerable <MonthlyClosing>, List<string>) SetErrorsReport(string errorStr)
        {
            _logger.Warning("It not possible generate the report.");

            return (false, [], new List<string> { "Month was blocked, but it not possible generate the report.", errorStr });
        }
    }

    public async Task SendToMessageBroker(int churchId, string churchName, string competence, IEnumerable<MonthlyClosing> flowJsonFile)
    {
        var @event = new MonthClosed();
        await @event.PreparePublish(new monthlyClosedEvents(churchId, churchName, competence, flowJsonFile.ToList()));
    }
}
