using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.OutFlow;
using Serilog;
using Microsoft.Extensions.Configuration;
using Registration.Handlers.CloudHandlers;
using Registration.Mapper.DTOs.Registration.Tithes;
using System.Linq;
using CloudServices.AWS;
using Microsoft.Identity.Client.Extensions.Msal;
using Registration.DomainCore.CloudAbstration;

namespace Registration.Handlers.Handlers.Registrations;
public sealed class OutFlowHanler : BaseRegisterNormalHandler
{
    private IOutFlowRepository _context;
    private OperationsHandler _operationsHandler;
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly IImageStorage _storage;
    public OutFlowHanler(IOutFlowRepository context, IMapper mapper, CViewModel viewModel, OperationsHandler operationsHandler, ILogger logger, IConfiguration configuration, IImageStorage storage) : base(mapper, viewModel)
    {
        _context = context;
        _operationsHandler = operationsHandler;
        _logger = logger;
        _configuration = configuration;
        _storage = storage;
    }

    protected override async Task<bool> MonthWorkIsBlockAsync(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        if(monthWork != null)
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel!.SetErrors("This competence has already been closed!");
            _logger.Error("This competence has already been closed!");
            return true;
        }
        
        return false;
    }

    public async Task<CViewModel> GetAll(int churchId, bool active = true)
    {
        _logger.Information("OutFlow - attemp get all");

        try
        {
            var outFlowExpression = Querie<OutFlow>.GetActive(active);

            var outFlowQuery = _context.GetAll();
            var outFlow = await outFlowQuery!
                .Where(outFlowExpression)
                .Where(x => x.ChurchId == churchId)
                .Include(x => x.OutFlowKind)
                .Include(x => x.Church)
                .ToListAsync();

            var outFlowReadDto = _mapper.Map<IEnumerable<ReadOutFlowDto>>(outFlow);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(outFlowReadDto);

            _logger.Information("{total} outflow was found", outFlow.Count);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OT1101A");
            _logger.Error("Fail get all {error} - OT110A1", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        _logger.Information("OutFlow - attemp get one");

        try
        {
            var outFlow = await _context.GetOne(id);
            if (outFlow == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The outflow with id {id} was not found", id);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadOutFlowDto>(outFlow);
            _viewModel.SetData(outFlowReadDto);

            _logger.Information("outflow was found");
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OT1102A");
            _logger.Error("Fail get one {error} - OT1102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetAllByMonth(string yearMonth, int churchId)
    {
        _logger.Information("OutFlow - attemp get all by month");

        try
        {
            var competence = $"{yearMonth.Substring(0, 4)}-{yearMonth.Substring(4, 2)}-01";

            if (!ValidateCompetence(competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - FF1103A");
                _logger.Error("Invalid competence");
                return _viewModel;
            }

            var outFlow = await _context.GetAllByMonth(yearMonth, churchId);
            if (outFlow == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("No outflow was found for church with id {id}", churchId);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<List<ReadOutFlowDto>>(outFlow);
            _viewModel.SetData(outFlowReadDto);

            _logger.Information("{total} outflow was found", outFlow.Count);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OT1102A");
            _logger.Error("Fail - get all by month {error} - OT1102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditOutFlowDto dto)
    {
        _logger.Information("OutFlow - attemp create");

        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        if (await MonthWorkIsBlockAsync(dto.Competence!, dto.ChurchId))
            return _viewModel;

        try
        {
            var outFlow = _mapper.Map<OutFlow>(dto);
            outFlow.CalculateTotalAmount();

            //verificar o totalAmount
            outFlow.UpdateData();
            await _context.Post(outFlow)!;

            await SaveImageStoreAsync(outFlow.Photo!, dto.base64Image);

            var newOutFlow = await _context.GetOne(outFlow.Id);

            var outFlowReadDto = _mapper.Map<ReadOutFlowDto>(newOutFlow);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(outFlowReadDto);

            _logger.Information("Outflow was successfully created");
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - OT1103A");
            _logger.Error("Fail - create {error} - OT1103A", ex.Message);
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - OT1103B");
            _logger.Error("Fail - create {error} - OT1103B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditOutFlowDto dto, int id)
    {
        _logger.Information("OutFlow - attemp update");

        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");

            return _viewModel;
        }

        if (await MonthWorkIsBlockAsync(dto.Competence!, dto.ChurchId))
            return _viewModel;

        try
        {
            var outFlow = await _context.GetOne(id);
            if (outFlow == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The outflow with id {id} was not found", id);
            }

            var editOutFlow = _mapper.Map<OutFlow>(dto);
            outFlow!.UpdateChanges(editOutFlow);
            outFlow.UpdateData();

            await _context.Put(outFlow);

            await SaveImageStoreAsync(outFlow.Photo!, dto.base64Image);

            var userReadDto = _mapper.Map<ReadOutFlowDto>(editOutFlow);

            _statusCode = (int)Scode.OK;

            _logger.Information("The outflow was successfully updated");
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - OT1104A");
            _logger.Error("Fail - update {error} - OT1104A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error. - OT1104B");
            _logger.Error("Fail - update {error} - OT1104B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        _logger.Information("OutFlow - attemp delete one");

        try
        {
            var otFlow = await _context.GetOne(id);
            if (otFlow == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The outflow with id {id} was not found", id);
                return _viewModel;
            }

            if (await MonthWorkIsBlockAsync(otFlow.Competence, otFlow.ChurchId))
                return _viewModel;            

            await _context.Delete(otFlow);

            _statusCode = (int)Scode.OK;

            _logger.Information("The outflow was successfully deleted");
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - OT1105A");
            _logger.Error("Fail - delete {error} - OT1105A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - OT1105B");
            _logger.Error("Fail - delete {error} - OT1105B", ex.Message);
        }

        return _viewModel;
    }

    private async Task SaveImageStoreAsync(string fileName, string? base64Image)
    {
        ModelImage serviceImage = new("outflow", fileName, _logger, _storage);
        await serviceImage.SaveImageStoreAsync(base64Image);
    }

    public async Task<CViewModel> GetByPeriod(int churchId, string initialDate, string finalDate, bool active)
    {
        _logger.Information("OutFlow - attemp get all by period");

        try
        {
            if (!ValidateCompetence(initialDate) | !ValidateCompetence(finalDate))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - E2E53D27");
                _logger.Error("Invalid period");
                return _viewModel;
            }

            var outFlowExpression = Querie<OutFlow>.GetActive(active);

            initialDate = DateTime.Parse(initialDate).ToString("yyyy-MM-dd");
            finalDate = DateTime.Parse(finalDate).ToString("yyyy-MM-dd");

            var outFlowQuery = _context.GetAll();
            var outFlow = await outFlowQuery!
                .Where(outFlowExpression)
                .Where(x => x.Day >= DateTime.Parse(initialDate))
                .Where(x => x.Day <= DateTime.Parse(finalDate))
                .Where(x => x.ChurchId ==  churchId)
                .Include(x => x.OutFlowKind)
                .ToListAsync();

            var tithesReadDto = _mapper.Map<IEnumerable<ReadOutFlowDto>>(outFlow);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);

            _logger.Information("{total} OutFlow was found", outFlow.Count);
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OTT1104B");
            _logger.Error("Fail get all {error} - OTT1104B", ex.Message);
        }

        return _viewModel;
    }
}