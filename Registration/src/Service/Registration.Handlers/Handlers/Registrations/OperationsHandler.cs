using AutoMapper;
using MessageBroker.Messages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Registration.MonthWork;
using Registration.Repository.Repository.Operations;
using Serilog;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers.Registrations;

public class OperationsHandler : BaseNormalHandler
{
    IMonthWorkRepository _context;
    private readonly IConfiguration _configuration;
    private IMonthlyClosingDataBase _mysqlDataBase;
    private string _competence;
    private readonly ILogger _logger;
    private readonly IMonthlyClosingDataBase _monthlyClosingRepository;

    public OperationsHandler(IMapper mapper, CViewModel viewModel, IMonthWorkRepository context, IConfiguration configuration, ILogger logger, IMonthlyClosingDataBase monthlyClosingRepository)
        : base(mapper, viewModel)
    {
        _context = context;
        _configuration = configuration;
        _logger = logger;
        _monthlyClosingRepository = monthlyClosingRepository;
    }


    public async Task<CViewModel> BlockMonthWork(EditMonthWorkDto editMonthYorkDto)
    {
        _logger.Information("Attemp to block month");

        try
        {
            editMonthYorkDto.Validate();

            _competence = editMonthYorkDto.YearMonth.ToString().Substring(0, 4) + "-" +
            editMonthYorkDto.YearMonth.ToString().Substring(4, editMonthYorkDto.YearMonth.ToString().Length - 4) + "-" + "01";

            _logger.Information("Compentence to block {competence}", _competence);

            if (!editMonthYorkDto.IsValid | !ValidateCompetence(_competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors(editMonthYorkDto.GetNotification());
                _logger.Information("Invalid properties. Check the properties");
                return _viewModel;
            }

            await RunBlock(editMonthYorkDto);
            _logger.Information("The competence {competence} was successfully bloacked!", _competence);

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

    private async Task RunBlock(EditMonthWorkDto editMonthYorkDto)
    {
        var monthWork = await _context.GetOneByCompetence(editMonthYorkDto.YearMonth, editMonthYorkDto.ChurchId);
        if (monthWork is not null)
        {
           await _context.Update(monthWork);
        }
        else
        {
            monthWork = _mapper.Map<MonthWork>(editMonthYorkDto);
            await _context.Create(monthWork);
        }
        
        var readMonthWork = _mapper.Map<ReadMonthWorkDto>(monthWork);
        _statusCode = (int)Scode.CREATED;
        _viewModel.SetData(readMonthWork);

        //Make the select for get movements and return a json
        await CallRecord(editMonthYorkDto);

        SendToMessageBroker(monthWork.ChurchId, _competence);
    }

    private async Task CallRecord(EditMonthWorkDto editMonthYorkDto)
    {
        _logger.Information("Report generate");

        try
        {
            //_mysqlDataBase = new MysqlMonthlyClosingRepository(_configuration);
            var report = new Report(_monthlyClosingRepository, editMonthYorkDto.ChurchId, _competence);
            var jsonReport = await report.Generate();

            if (jsonReport != null)
                _viewModel.SetData(jsonReport!);
        }
        catch(MySqlException ex)
        {
            _logger.Error("(ER-OPH01) Error with database. {error}", ex.Message);
            SetErrorsReport(ex.Message);
        }
        catch(InvalidDataException ex)
        {
            _logger.Error("(ER-OPH02) Error with properties. Check the churchId and competence {error}", ex);
            SetErrorsReport(ex.Message);
        }
        catch(Exception ex)
        {
            _logger.Error("(ER-OPH03) Error during generation the report {error}", ex);
            SetErrorsReport(ex.Message);
        }

        void SetErrorsReport(string errorStr)
        {
            _viewModel.SetErrors(new List<string>()
            {
                "Month was blocked, but it not possible generate the report.",
                errorStr
            });

            _logger.Warning("Month was blocked, but it not possible generate the report.");
        }

    }
    private void SendToMessageBroker(int churchId, string competence)
    {
        return;

        //var blockMonthWorkMessage = new BlockMonthWorkMessage(_configuration, churchId, competence);
        //blockMonthWorkMessage.PreparePublish();
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
        catch(Exception ex)
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
        catch(Exception ex)
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
}
