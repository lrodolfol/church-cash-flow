using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations.Helpers;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Registration.MonthWork;
using Serilog;
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
        _serviceProvider = serviceProvider;
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

            MonthlyClosingHelper = new MonthlyClosingHelper(_serviceProvider);

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
        try
        {
            var monthWork = await _context.GetOne(id);
            if (monthWork is null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Information("The periodo was not found or its not blocked");

                return _viewModel;
            }

            await _context.Remove(monthWork);
            _statusCode = (int)Scode.NO_CONTENT;

            var competence = 
                $"{monthWork.YearMonth.ToString().Substring(0, 4)}-{monthWork.YearMonth.ToString().Substring(4, 2)}-01";
            
            MonthlyClosingHelper = new MonthlyClosingHelper(_serviceProvider);
            await MonthlyClosingHelper.DeleBlockMonthOnMessageBrokerAsync(
                monthWork.ChurchId, monthWork.Church!.Name!, competence
                );

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
        IEnumerable<ReadMonthWorkDto>? MonthWReadDto;

        try
        {
            var monthW = await _context.GetByChurchByYear(churchId, year);

            MonthWReadDto = _mapper.Map<IEnumerable<ReadMonthWorkDto>>(monthW);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(MonthWReadDto);
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
        IEnumerable<ReadMonthWorkDto>? MonthWReadDto;

        try
        {
            var monthW = await _context.GetAllByYear(year);
            MonthWReadDto = _mapper.Map<IEnumerable<ReadMonthWorkDto>>(monthW);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(MonthWReadDto);
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
        IEnumerable<ReadMonthWorkDto>? MonthWReadDto;

        try
        {
            var monthWExpression = Querie<MonthWork>.GetActive(true);

            var MonthWQuery = _context.GetAll(churchId);
            var monthW = await MonthWQuery.Where(monthWExpression).ToListAsync();
            MonthWReadDto = _mapper.Map<IEnumerable<ReadMonthWorkDto>>(monthW);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(MonthWReadDto);


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
        MonthWork? monthWork = await _context.GetOneByCompetence(editMonthYorkDto.YearMonth, editMonthYorkDto.ChurchId);

        if (monthWork is not null && monthWork.Active == true)
        {
            _viewModel.SetErrors(new List<string> { "This competence has been closed!" });
            return;
        }

        monthWork = _mapper.Map<MonthWork>(editMonthYorkDto);

        var readMonthWork = _mapper.Map<ReadMonthWorkDto>(monthWork);

        (bool Success, IEnumerable<MonthlyClosing> JsonFile, List<string> Messages) returnTuple =
            await MonthlyClosingHelper.CallRecord(editMonthYorkDto, competence);

        if (!returnTuple.Success)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors(returnTuple.Messages);
        }
        else
        {
            var churchRepository = _serviceProvider.GetRequiredService<IChurchRepository>();
            var church = await churchRepository.GetOne(editMonthYorkDto.ChurchId);

            monthWork.SetFinalValue(returnTuple.JsonFile.LastOrDefault(new MonthlyClosing() { CurrentBalance = 0 }).CurrentBalance);
            monthWork.SetInitialValue(returnTuple.JsonFile.FirstOrDefault(new MonthlyClosing() { CurrentBalance = 0 }).CurrentBalance);
            await _context.Create(monthWork);

            _viewModel.SetData(returnTuple.JsonFile);
            _statusCode = (int)Scode.CREATED;

            await MonthlyClosingHelper.PostBlockMonthOnMessageBroker(
                monthWork.ChurchId,
                church.Name!,
                competence,
                returnTuple.JsonFile
            );
        }
    }
}
