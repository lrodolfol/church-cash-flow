using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Tithes;
using Serilog;

namespace Registration.Handlers.Handlers.Registrations;
public sealed class TithesHanler : BaseRegisterNormalHandler
{
    private ITithesRepository _context;
    private OperationsHandler _operationsHandler;
    private readonly ILogger _logger;

    public TithesHanler(ITithesRepository context, UserHandler userHandler, IMapper mapper, CViewModel viewModel, OperationsHandler operationsHandler, ILogger logger) : base(mapper, viewModel)
    {
        _context = context;
        _operationsHandler = operationsHandler;
        _logger = logger;
    }

    protected override async Task<bool> MonthWorkIsBlockAsync(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        if(monthWork != null)
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel!.SetErrors("This competence has already been closed!");

            return true;
        }

        return false;
    }

    public async Task<CViewModel> GetAll(int churchId, bool active = true)
    {
        _logger.Information("Tithes - attemp get all");

        try
        {
            var tithesExpression = Querie<Tithes>.GetActive(active);

            var outFlowQuery = _context.GetAll(churchId);
            var tithes = await outFlowQuery
                .Where(tithesExpression)
                .Include(x => x.Member)
                .Include(x => x.OfferingKind)
                .Include(x => x.Church)
                .ToListAsync();

            var tithesReadDto = _mapper.Map<IEnumerable<ReadTithesDto>>(tithes);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);

            _logger.Information("{total} tithes was found", tithes.Count);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1101A");
            _logger.Error("Fail get all {error} - TH1101A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        _logger.Information("Tithes - attemp get one");

        try
        {
            var tithes = await _context.GetOne(id);

            if (tithes == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The tithes with id {id} was not found", id);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadTithesDto>(tithes);
            _viewModel.SetData(outFlowReadDto);

            _logger.Information("tithes was found");
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1102A");
            _logger.Error("Fail get one {error} - TH1102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOneByChurch(int churchId, int id)
    {
        _logger.Information("Tithes - attemp get all by church");

        try
        {
            var tithes = await _context.GetOneByChurch(churchId, id);

            if (tithes == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("No tithes was found for church with id {id}", churchId);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadTithesDto>(tithes);
            _viewModel.SetData(outFlowReadDto);

            _logger.Information("the tithe was found");
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1102A");
            _logger.Error("Fail - get one by church {error} - TH1102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetAllByCompetence(int churchId, string yearMonth, bool active = true)
    {
        _logger.Information("OutFlow - attemp get all by competence");

        try
        {
            var competence = $"{yearMonth.Substring(0, 4)}-{yearMonth.Substring(4, 2)}-01";

            if (!ValidateCompetence(competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - TH1103A");
                _logger.Error("The competence is invalid");
                return _viewModel;
            }

            var tithesExpression = Querie<Tithes>.GetActive(active);

            var tithesQuery = _context.GetAll(churchId);
            var tithes = await tithesQuery
                .Where(tithesExpression)
                .Where(x => x.Day.Year == DateTime.Parse(competence).Year && x.Day.Month == DateTime.Parse(competence).Month)
                .Include(x => x.Church)
                .Include(x => x.OfferingKind)
                .Include(x => x.Member)
                .ToListAsync();

            var tithesReadDto = _mapper.Map<IEnumerable<ReadTithesDto>>(tithes);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);

            _logger.Information("{total} outflow was found", tithes.Count);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1103B");
            _logger.Error("Fail get all {error} - TH1103B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetByPeriod(int churchId, string initialDate, string finalDate, bool active)
    {
        _logger.Information("OutFlow - attemp get all by period");

        try
        {
            if (!ValidateCompetence(initialDate) | !ValidateCompetence(finalDate))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - TH1104A");
                _logger.Error("Invalid period");
                return _viewModel;
            }

            var tithesExpression = Querie<Tithes>.GetActive(active);

            initialDate = DateTime.Parse(initialDate).ToString("yyyy-MM-dd");
            finalDate = DateTime.Parse(finalDate).ToString("yyyy-MM-dd");

            var tithesQuery = _context.GetAll(churchId);
            var tithes = await tithesQuery
                .Where(tithesExpression)
                .Where(x => x.Day >= DateTime.Parse(initialDate))
                .Where(x => x.Day <= DateTime.Parse(finalDate))
                .Include(x => x.Member)
                .Include(x => x.OfferingKind)
                .Include(x => x.Church)
                .ToListAsync();

            var tithesReadDto = _mapper.Map<IEnumerable<ReadTithesDto>>(tithes);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);

            _logger.Information("{total} tithes was found", tithes.Count);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1104B");
            _logger.Error("Fail get all {error} - TH1104B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditTithesDto tithesEditDto)
    {
        _logger.Information("OutFlow - attemp create");

        tithesEditDto.Validate();
        if (!tithesEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(tithesEditDto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        if (await MonthWorkIsBlockAsync(tithesEditDto.Competence, tithesEditDto.ChurchId))
            return _viewModel;

        try
        {
            var tithes = _mapper.Map<Tithes>(tithesEditDto);
            await _context.Post(tithes)!;

            var newTithes = await _context.GetOne(tithes.Id);

            var tithesReadDto = _mapper.Map<ReadTithesDto>(newTithes);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(tithesReadDto);

            _logger.Information("Tithes was successfully created");
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - TH1105A");
            _logger.Error("Fail - create {error} - TH1105A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - TH1105B");
            _logger.Error("Fail - create {error} - TH1105B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditTithesDto tithesEditDto, int id)
    {
        _logger.Information("Tithes - attemp update");

        tithesEditDto.Validate();
        if (!tithesEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(tithesEditDto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        if (await MonthWorkIsBlockAsync(tithesEditDto.Competence!, tithesEditDto.ChurchId))
            return _viewModel;
        
        try
        {
            var tithes = await _context.GetOne(id);
            if (tithes == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The tithes with id {id} was not found", id);
                return _viewModel;
            }

            var editTithes = _mapper.Map<Tithes>(tithesEditDto);
            tithes.UpdateChanges(editTithes);

            await _context.Put(tithes);

            _statusCode = (int)Scode.OK;

            _logger.Information("The tithe was successfully updated");
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - TH1106A");
            _logger.Error("Fail - update {error} - TH1106A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error. - TH1106B");
            _logger.Error("Fail - update {error} - OT1104B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        _logger.Information("Tithes - attemp delete one");

        try
        {
            var tithes = await _context.GetOne(id);
            if (tithes == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The outflow with id {id} was not found", id);
                return _viewModel;
            }

            if (await MonthWorkIsBlockAsync(tithes.Competence, tithes.ChurchId))
                return _viewModel;

            await _context.Delete(tithes);

            _statusCode = (int)Scode.OK;

            _logger.Information("The tithes was successfully deleted");
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - TH1107A");
            _logger.Error("Fail - delete {error} - TH1107A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - TH1107B");
            _logger.Error("Fail - delete {error} - TH1107B", ex.Message);
        }

        return _viewModel;
    }


}