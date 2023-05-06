using AutoMapper;
using MessageBroker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Offering;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers;

public class OperationsHandler : Handler
{
    IMonthWorkRepository _context;
    private readonly IConfiguration _configuration;

    public OperationsHandler(IMapper mapper, CViewModel viewModel, IMonthWorkRepository context, IConfiguration configuration)
        : base(mapper, viewModel)
    {
        _context = context;
        _configuration = configuration;
    }

    protected override Task<bool> MonthWorkIsBlock(string competence, int churchId)
    {
        //ferindo solid
        throw new NotImplementedException();
    }

    public async Task<CViewModel> BlockMonthWork(EditMonthWorkDto editMonthYorkDto)
    {
        try
        {
            editMonthYorkDto.Validate();

            var competence = editMonthYorkDto.YearMonth.ToString().Substring(0, 4) + "-" +
            editMonthYorkDto.YearMonth.ToString().Substring(4, editMonthYorkDto.YearMonth.ToString().Length - 4) + "-" + "01";

            if (!editMonthYorkDto.IsValid)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors(editMonthYorkDto.GetNotification());

                return _viewModel;
            }


            if (!ValidateCompetence(competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - OH1101A");

                return _viewModel;
            }

            var monthWork = _mapper.Map<MonthWork>(editMonthYorkDto);

            await _context.Create(monthWork);

            var readMonthWork = _mapper.Map<ReadMonthWorkDto>(monthWork);
            _statusCode = (int)Scode.CREATED;
            _viewModel.SetData(readMonthWork);

            SendToMessageBroker(monthWork.ChurchId, competence);

            return _viewModel;
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties. Maybe the month has already been block - OH1102A");

            return _viewModel;
        }

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

    private void SendToMessageBroker(int churchId, string competence)
    {
        var blockMonthWorkMessage = new BlockMonthWorkMessage(_configuration, churchId, competence);
        blockMonthWorkMessage.PreparePublish();
    }
}
