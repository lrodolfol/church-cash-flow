using AutoMapper;
using MessageBroker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.InterfaceRepository;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Offering;
using Registration.Repository;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers.Registrations;

public class OperationsHandler : BaseNormalHandler
{
    IMonthWorkRepository _context;
    private readonly IConfiguration _configuration;
    private IDataBase _mysqlDataBase;
    private string _competence;
    public OperationsHandler(IMapper mapper, CViewModel viewModel, IMonthWorkRepository context, IConfiguration configuration)
        : base(mapper, viewModel)
    {
        _context = context;
        _configuration = configuration;
    }


    public async Task<CViewModel> BlockMonthWork(EditMonthWorkDto editMonthYorkDto)
    {
        try
        {
            editMonthYorkDto.Validate();

            _competence = editMonthYorkDto.YearMonth.ToString().Substring(0, 4) + "-" +
            editMonthYorkDto.YearMonth.ToString().Substring(4, editMonthYorkDto.YearMonth.ToString().Length - 4) + "-" + "01";

            if (!editMonthYorkDto.IsValid)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors(editMonthYorkDto.GetNotification());

                return _viewModel;
            }


            if (!ValidateCompetence(_competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - OH1101A");

                return _viewModel;
            }

            await RunBlock(editMonthYorkDto);

            return _viewModel;
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties. Maybe the month has already been block - OH1102A");

            return _viewModel;
        }

    }

    private async Task RunBlock(EditMonthWorkDto editMonthYorkDto)
    {
        var monthWork = _mapper.Map<MonthWork>(editMonthYorkDto);

        await _context.Create(monthWork);

        var readMonthWork = _mapper.Map<ReadMonthWorkDto>(monthWork);
        _statusCode = (int)Scode.CREATED;
        _viewModel.SetData(readMonthWork);

        //Make the select for get movements and return a json
        var jsonReport = await CallRecord(editMonthYorkDto);

        SendToMessageBroker(monthWork.ChurchId, _competence);
    }

    private async Task<string?> CallRecord(EditMonthWorkDto editMonthYorkDto)
    {
        _mysqlDataBase = new MysqlDataBase(_configuration);
        var report = new Report(_mysqlDataBase, editMonthYorkDto.ChurchId, _competence);
        var jsonReport = await report.Generate();

        return jsonReport;
    }
    private void SendToMessageBroker(int churchId, string competence)
    {
        //return;

        var blockMonthWorkMessage = new BlockMonthWorkMessage(_configuration, churchId, competence);
        blockMonthWorkMessage.PreparePublish();
    }

    public async Task<CViewModel> UnblockMonthWork(int id)
    {
        try
        {
            var monthWork = await _context.GetOne(id);
            if (monthWork == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            await _context.Remove(monthWork);
            _statusCode = (int)Scode.NO_CONTENT;

            return _viewModel;
        }
        catch
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - OH1102B");

            return _viewModel;
        }
    }

    public async Task<CViewModel> GetAll(int churchId)
    {
        try
        {
            var monthWExpression = Querie<MonthWork>.GetActive(true);

            var MonthWQuery = _context.GetAll(churchId);
            var monthW = await MonthWQuery.Where(monthWExpression).ToListAsync();

            var MonthWReadDto = _mapper.Map<IEnumerable<ReadMonthWorkDto>>(monthW);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(MonthWReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OH1101A");
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
