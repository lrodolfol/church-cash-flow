using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.FirstFruits;
using Serilog;
using Registration.Mapper.DTOs.Registration.Offering;
using Registration.Mapper.DTOs.Registration.Tithes;
using Microsoft.Extensions.Configuration;
using Registration.Handlers.CloudHandlers;

namespace Registration.Handlers.Handlers.Registrations;
public sealed class FirstFruitsHanler : BaseRegisterNormalHandler
{
    private IFirstFruitsRepository _context;
    private OperationsHandler _operationsHandler;
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;

    public FirstFruitsHanler(IFirstFruitsRepository context, CViewModel viewModel, IMapper mapper, OperationsHandler operationsHandler, ILogger logger, IConfiguration configuration)
        : base(mapper, viewModel)
    {
        _context = context;
        _operationsHandler = operationsHandler;
        _logger = logger;
        _configuration = configuration;
    }

    protected override async Task<bool> MonthWorkIsBlockAsync(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        if(monthWork == null)
        {
            return false;
        }
        else
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel!.SetErrors("This competence has already been closed!");
            _logger.Error("This competence has already been closed!");

            return true;
        }
    }

    public async Task<CViewModel> GetAll(int churchId, bool active = true)
    {
        _logger.Information("FirstFruits - Attemp to get all");

        try
        {
            var firstFruitsExpression = Querie<FirstFruits>.GetActive(active);

            var outFlowQuery = _context.GetAll(churchId);
            var fruits = await outFlowQuery
                .Where(firstFruitsExpression)
                .Include(x => x.Member)
                .Include(x => x.OfferingKind)
                .Include(x => x.Church)
                .ToListAsync();

            var firstFruitsReadDto = _mapper.Map<IEnumerable<ReadFirstFruitsDto>>(fruits);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(firstFruitsReadDto);

            _logger.Information("{totalFf} was found", fruits.Count);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - FF1101A");
            _logger.Error("Fail get first fruits {error} - FF1101A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetAllByCompetence(int churchId, string yearMonth, bool active = true)
    {
        _logger.Information("FirstFruits - Attemp to get all by competence");

        try
        {
            var competence = $"{yearMonth.Substring(0, 4)}-{yearMonth.Substring(4, 2)}-01";

            if (!ValidateCompetence(competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - FF1103A");
                _logger.Error("The competence is invalid");
                return _viewModel;
            }

            var firstFruitsExpression = Querie<FirstFruits>.GetActive(active);

            var fruitsQuery = _context.GetAll(churchId);
            var fruits = await fruitsQuery
                .Where(firstFruitsExpression)
                .Where(x => x.Day.Year == DateTime.Parse(competence).Year && x.Day.Month == DateTime.Parse(competence).Month)
                .Include(x => x.Church)
                .Include(x => x.OfferingKind)
                .Include(x => x.Member)
                .ToListAsync();

            var fruitsReadDto = _mapper.Map<IEnumerable<ReadFirstFruitsDto>>(fruits);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(fruitsReadDto);

            _logger.Information("{totalFf} was found", fruits.Count);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - FF1103B");
            _logger.Error("Fail get first fruits by competence {error} - FF1103B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        _logger.Information("FirstFruits - Attemp to get one");

        try
        {
            var firstFruits = await _context.GetOne(id);
            if (firstFruits == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The first fruits with id {id} was not found", id);

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadFirstFruitsDto>(firstFruits);
            _viewModel.SetData(outFlowReadDto);

            _logger.Information("{totalFf} was found", outFlowReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - FF1102A");
            _logger.Error("Fail get first fruit {error} - FF1102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> CreateAsyn(EditFirstFruitsDto dto)
    {
        _logger.Information("FirstFruits - Attemp to create");

        if (!ValidateCreateEdit(dto))
            return _viewModel;

        try
        {
            var model = _mapper.Map<FirstFruits>(dto);
            
            model.UpdateData();
            await _context.Post(model)!;
            await SaveImageStoreAsync(model, model.Photo, dto.base64Image);

            var newFirstFruits = await _context.GetOne(model.Id);

            var firstFruitsReadDto = _mapper.Map<ReadFirstFruitsDto>(newFirstFruits);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(firstFruitsReadDto);

            _logger.Information("FirstFruits - First fruits successfully created");
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - FF1103A");
            _logger.Error("Fail create first fruits {error} - FF1103A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - FF1103B");
            _logger.Error("Fail create first fruits {error} - FF1103B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> UpdateAsyn(EditFirstFruitsDto dto, int id)
    {
        _logger.Information("FirstFruits - Attemp to update");

        if (!ValidateCreateEdit(dto))
            return _viewModel;

        try
        {
            var model = await _context.GetOne(id);
            if (model == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("First fruits with id {id} was not found", id);

                return _viewModel;
            }

            var editTithes = _mapper.Map<FirstFruits>(dto);
            model.UpdateChanges(editTithes);

            model.UpdateData();
            await _context.Put(model);
            await SaveImageStoreAsync(model, model.Photo, dto.base64Image);

            _statusCode = (int)Scode.OK;

            _logger.Information("The first fruis was successfully updated");
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - FF1104A");
            _logger.Error("Fail update first fruits {error} - FF1104A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - FF1104B");
            _logger.Error("Fail update first fruits {error} - FF1104B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        _logger.Information("FirstFruits - Attemp to delete");

        try
        {
            var firstFruits = await _context.GetOne(id);
            if (firstFruits == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("First fruits with id {id} was not found", id);

                return _viewModel;
            }

            if (await MonthWorkIsBlockAsync(firstFruits.Competence!, firstFruits.ChurchId))
                return _viewModel;

            await _context.Delete(firstFruits);

            _statusCode = (int)Scode.OK;

            _logger.Information("First fruits was successully deleted");
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - FF1105A");
            _logger.Error("Fail delete first fruits {error} - FF1105A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - FF1105B");
            _logger.Error("Fail delete first fruits {error} - FF1105B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetByPeriod(int churchId, string initialDate, string finalDate, bool active)
    {
        _logger.Information("FirstFruits - Attemp to get by period");

        try
        {
            if (!ValidateCompetence(initialDate) | !ValidateCompetence(finalDate))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - TH1104A");
                _logger.Error("Invalid properties. Check the properties");

                return _viewModel;
            }

            var tithesExpression = Querie<FirstFruits>.GetActive(active);

            initialDate = DateTime.Parse(initialDate).ToString("yyyy-MM-dd");
            finalDate = DateTime.Parse(finalDate).ToString("yyyy-MM-dd");

            var tithesQuery = _context.GetAll(churchId);
            var fruits = await tithesQuery
                .Where(tithesExpression)
                .Where(x => x.Day >= DateTime.Parse(initialDate))
                .Where(x => x.Day <= DateTime.Parse(finalDate))
                .Include(x => x.Member)
                .Include(x => x.OfferingKind)
                .Include(x => x.Church)
                .ToListAsync();

            var tithesReadDto = _mapper.Map<IEnumerable<ReadFirstFruitsDto>>(fruits);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);

            _logger.Information("{totalFf} was found", fruits.Count);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1104B");
            _logger.Error("Fail update first fruits {error} - FF1104B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOneByChurchAsync(int churchId, int id)
    {
        _logger.Information("Offering - attemp get one by church");

        try
        {
            var fruits = TryGetOneByChurch(churchId, id);
            if (fruits == null)
                return _viewModel;

            var offeringReadDto = _mapper.Map<ReadFirstFruitsDto>(fruits);
            _viewModel.SetData(offeringReadDto);
            _logger.Information("The offering with id {id} was found", id);
            _statusCode = (int)Scode.OK;
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1105A");
            _logger.Error("Fail - get one by church {error} - TH1105A", ex.Message);
        }

        return _viewModel;
    }

    private FirstFruits? TryGetOneByChurch(int churchId, int id)
    {
        var fruits = _context.GetOneByChurch(churchId, id);
        if (fruits.Result == null)
        {
            _statusCode = (int)Scode.OK;
            _viewModel!.SetErrors("Object not found");
            _logger.Information("Offering with id {id} was not found for church {idChurch}", id, churchId);
            return null;
        }

        return fruits.Result;
    }

    private async Task SaveImageStoreAsync(FirstFruits model, string fileName, string? base64Image)
    {
        ModelImage serviceImage = new("first-fruits", fileName, _logger);
        await serviceImage.SaveImageStoreAsync(base64Image);
    }

    private bool ValidateCreateEdit(EditFirstFruitsDto dto)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid properties. Check the properties");

            return false;
        }

        var monthBlock = MonthWorkIsBlockAsync(dto!.Competence!, dto.ChurchId);
        monthBlock.Wait();  
        if (monthBlock.Result == true)
            return false;

        return true;
    }
}