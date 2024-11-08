using AutoMapper;
using MessageBroker.Messages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ServicesAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations.Helpers;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Registration.MonthWork;
using Registration.Repository.Repository.Operations;
using Serilog;
using System.Text.Json;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers.Registrations;

public class OperationsHandler : BaseNormalHandler
{
    IMonthWorkRepository _context;
    private readonly IConfiguration _configuration;
    ///private IMonthlyClosingDataBase _mysqlDataBase;
    private readonly ILogger _logger;
    //private readonly IMonthlyClosingDataBase _monthlyClosingRepository;
    //private readonly ICacheService _cache;
    private readonly IServiceProvider _serviceProvider;

    private MonthlyClosingHelper MonthlyClosingHelper = null!;

    public OperationsHandler(IMapper mapper, CViewModel viewModel, IMonthWorkRepository context, IConfiguration configuration, ILogger logger, IServiceProvider serviceProvider)
        : base(mapper, viewModel)
    {
        _context = context;
        _configuration = configuration;
        _logger = logger;
        //_monthlyClosingRepository = monthlyClosingRepository;
        _serviceProvider = serviceProvider;

        //_cache = _serviceProvider.GetRequiredService<ICacheService>();
    }


    public async Task<CViewModel> BlockMonthWork(EditMonthWorkDto editMonthYorkDto)
    {
        try
        {
            editMonthYorkDto.Validate();

            var competence = editMonthYorkDto.YearMonth.ToString().Substring(0, 4) + "-" +
            editMonthYorkDto.YearMonth.ToString().Substring(4, editMonthYorkDto.YearMonth.ToString().Length - 4) + "-" + "01";

            if (!editMonthYorkDto.IsValid | !ValidateCompetence(competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors(editMonthYorkDto.GetNotification());
                _logger.Information("Invalid properties. Check the properties");
                return _viewModel;
            }

            MonthlyClosingHelper = new MonthlyClosingHelper(_serviceProvider, competence!);

            await RunBlock(editMonthYorkDto, competence);

            return _viewModel;
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties. Maybe the month has already been block - OH1102A");
            _logger.Error("Fail - block month", ex.Message);
            return _viewModel;
        }

    }

    public async Task<CViewModel> UnblockMonthWork(int id)
    {
        _logger.Information("Attemp to unblock month");

        try
        {
            var monthWork = await _context.GetOne(id);
            if (monthWork == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Information("The periodo was not found or its not blocked");

                return _viewModel;
            }

            await _context.Update(monthWork);
            _statusCode = (int)Scode.NO_CONTENT;
            _logger.Information("The period was unblocked");

            return _viewModel;
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - OH1102B");
            _logger.Error("Fail - try unblock period", ex.Message);
            return _viewModel;
        }
    }

    public async Task<CViewModel> GetByChurchByYear(int churchId, int year)
    {
        _logger.Information("Month work - attemp get all by year");

        try
        {
            var monthW = await _context.GetByChurchByYear(churchId, year);

            var MonthWReadDto = _mapper.Map<IEnumerable<ReadMonthWorkDto>>(monthW);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(MonthWReadDto);

            _logger.Information("Return values - total, {total}", monthW.Count);
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OH4101BR");
            _logger.Error("Fail get all month", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetAllByYear(int year)
    {
        _logger.Information("Month work - attemp get all by year");

        try
        {
            var monthW = await _context.GetAllByYear(year);

            var MonthWReadDto = _mapper.Map<IEnumerable<ReadMonthWorkDto>>(monthW);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(MonthWReadDto);

            _logger.Information("Return values - total, {total}", monthW.Count);
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OH41B6R");
            _logger.Error("Fail get all month", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetAll(int churchId)
    {
        _logger.Information("Month work - attemp get all month");

        try
        {
            var monthWExpression = Querie<MonthWork>.GetActive(true);

            var MonthWQuery = _context.GetAll(churchId);
            var monthW = await MonthWQuery.Where(monthWExpression).ToListAsync();

            var MonthWReadDto = _mapper.Map<IEnumerable<ReadMonthWorkDto>>(monthW);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(MonthWReadDto);

            _logger.Information("All month was found. total - {total}", monthW.Count);
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OH1101A");
            _logger.Error("Fail get all month", ex.Message);
        }

        return _viewModel;
    }

    public async Task<MonthWork> GetOneByCompetence(string yearMonth, int churchId)
    {
        var competence = int.Parse(yearMonth);

        var monthW = await _context.GetOneByCompetenceAsNoTracking(competence, churchId);
        return monthW;
    }


    private async Task RunBlock(EditMonthWorkDto editMonthYorkDto, string competence)
    {
        var monthWork = await _context.GetOneByCompetence(editMonthYorkDto.YearMonth, editMonthYorkDto.ChurchId);
        if (monthWork is not null && monthWork.Active == true)
        {
            _viewModel.SetErrors(new List<string> { "This competence has been closed!" });
            return;
        }

        monthWork = _mapper.Map<MonthWork>(editMonthYorkDto);
        await _context.Create(monthWork);

        var readMonthWork = _mapper.Map<ReadMonthWorkDto>(monthWork);
        //_statusCode = (int)Scode.CREATED;
        //_viewModel.SetData(readMonthWork);

        //Make the select for get movements and return a json
        (bool Success, List<string> Messages) returnTuple = await MonthlyClosingHelper.CallRecord(editMonthYorkDto);
        await MonthlyClosingHelper.SetCachingAsync(editMonthYorkDto, readMonthWork);
        MonthlyClosingHelper.SendToMessageBroker(monthWork.ChurchId, competence);

        if (!returnTuple.Success)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors(returnTuple.Messages);
        }
        else
        {
            _viewModel.SetData(returnTuple.Messages);
            _statusCode = (int)Scode.CREATED;
        }
    }
}
