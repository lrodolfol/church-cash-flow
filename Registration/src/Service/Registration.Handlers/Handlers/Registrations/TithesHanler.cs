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
using Microsoft.Extensions.Configuration;
using Registration.Handlers.CloudHandlers;
using Registration.DomainCore.CloudAbstration;
using Microsoft.Extensions.Caching.Memory;

namespace Registration.Handlers.Handlers.Registrations;
public sealed class TithesHanler : BaseRegisterNormalHandler
{
    private ITithesRepository _context;
    private OperationsHandler _operationsHandler;
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly IImageStorage _storage;
    private readonly IMemoryCache _cache;
    private const string _cacheKey = "TITHES";

    private static Dictionary<string, IEnumerable<ReadTithesDto>?> HashGetByPeriod = new();
    public TithesHanler(ITithesRepository context, UserHandler userHandler, IMapper mapper, CViewModel viewModel, OperationsHandler operationsHandler, ILogger logger, IConfiguration configuration, IImageStorage storage, IMemoryCache cache) : base(mapper, viewModel)
    {
        _context = context;
        _operationsHandler = operationsHandler;
        _logger = logger;
        _configuration = configuration;
        _storage = storage;
        _cache = cache;
    }

    protected override async Task<bool> MonthWorkIsBlockAsync(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        if(monthWork != null && monthWork.Active == false)
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel!.SetErrors("This competence has already been closed!");

            return true;
        }

        return false;
    }

    public async Task<CViewModel> GetAll(int churchId, bool active = true)
    {
        IEnumerable<ReadTithesDto>? tithesReadDto;

        try
        {
            tithesReadDto = await _cache.GetOrCreateAsync(_cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                var tithesExpression = Querie<Tithes>.GetActive(active);

                var outFlowQuery = _context.GetAll(churchId);
                var tithes = await outFlowQuery
                    .Where(tithesExpression)
                    .Include(x => x.Member)
                    .Include(x => x.OfferingKind)
                    .Include(x => x.Church)
                    .ToListAsync();

                return _mapper.Map<IEnumerable<ReadTithesDto>>(tithes);
            });

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);
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
        ReadTithesDto? outFlowReadDto;

        try
        {
            outFlowReadDto = await _cache.GetOrCreateAsync($"{_cacheKey}-{id}", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                var tithes = await _context.GetOne(id);
                return _mapper.Map<ReadTithesDto>(tithes);
            }); 

            if (outFlowReadDto == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The tithes with id {id} was not found", id);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(outFlowReadDto);
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
        ReadTithesDto? outFlowReadDto;

        try
        {
            outFlowReadDto = await _cache.GetOrCreateAsync($"{_cacheKey}-{churchId}-{id}", async entry =>
            {
                var tithes = await _context.GetOneByChurch(churchId, id);
                return _mapper.Map<ReadTithesDto>(tithes);
            });

            if (outFlowReadDto == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("No tithes was found for church with id {id}", churchId);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(outFlowReadDto);
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
        IEnumerable<ReadTithesDto>? tithesReadDto;

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

            var cacheName = $"{_cacheKey}-{churchId}-{yearMonth}";
            tithesReadDto = await _cache.GetOrCreateAsync(cacheName, async entry =>
            {
                var tithesExpression = Querie<Tithes>.GetActive(active);

                var tithesQuery = _context.GetAll(churchId);
                var tithes = await tithesQuery
                    .Where(tithesExpression)
                    .Where(x => x.Day.Year == DateTime.Parse(competence).Year && x.Day.Month == DateTime.Parse(competence).Month)
                    .Include(x => x.Church)
                    .Include(x => x.OfferingKind)
                    .Include(x => x.Member)
                    .ToListAsync();

                return _mapper.Map<IEnumerable<ReadTithesDto>>(tithes);
            });

            HashGetByPeriod.TryAdd(cacheName, tithesReadDto);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);
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
        IEnumerable<ReadTithesDto>? tithesReadDto;

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

            var cacheName = $"{_cacheKey}-{churchId}-{initialDate}-{finalDate}";
            tithesReadDto = await _cache.GetOrCreateAsync(cacheName, async entry =>
            {
                var tithesQuery = _context.GetAll(churchId);
                var tithes = await tithesQuery
                    .Where(tithesExpression)
                    .Where(x => x.Day >= DateTime.Parse(initialDate))
                    .Where(x => x.Day <= DateTime.Parse(finalDate))
                    .Include(x => x.Member)
                    .Include(x => x.OfferingKind)
                    .Include(x => x.Church)
                    .ToListAsync();

                return _mapper.Map<IEnumerable<ReadTithesDto>>(tithes);
            });

            HashGetByPeriod.TryAdd(cacheName, tithesReadDto);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1104B");
            _logger.Error("Fail get all {error} - TH1104B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditTithesDto dto)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        if (await MonthWorkIsBlockAsync(dto.Competence, dto.ChurchId))
            return _viewModel;

        try
        {
            var tithes = _mapper.Map<Tithes>(dto);
            tithes.UpdateData();
            await _context.Post(tithes)!;

            await SaveImageStoreAsync(tithes, tithes.Photo!, dto.base64Image);

            var newTithes = await _context.GetOne(tithes.Id);

            var tithesReadDto = _mapper.Map<ReadTithesDto>(newTithes);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(tithesReadDto);

            _cache.Remove(_cacheKey);
            foreach(var item in HashGetByPeriod)
                _cache.Remove(item.Key);
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - TH1105A");
            _logger.Error("Fail - create {error} - TH1105A", ex.InnerException);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - TH1105B");
            _logger.Error("Fail - create {error} - TH1105B", ex.InnerException);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditTithesDto dto, int id)
    {
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
            var tithes = await _context.GetOne(id);
            if (tithes == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The tithes with id {id} was not found", id);
                return _viewModel;
            }

            var editTithes = _mapper.Map<Tithes>(dto);
            tithes.UpdateChanges(editTithes);

            tithes.UpdateData();
            await _context.Put(tithes);

            await SaveImageStoreAsync(tithes, tithes.Photo!, dto.base64Image);

            _statusCode = (int)Scode.OK;

            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{dto.ChurchId}-{id}");
            _cache.Remove($"{_cacheKey}-{id}");
            foreach(var item in HashGetByPeriod)
                _cache.Remove(item.Key);
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - TH1106A");
            _logger.Error("Fail - update {error} - TH1106A", ex.InnerException);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error. - TH1106B");
            _logger.Error("Fail - update {error} - OT1104B", ex.InnerException);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
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

            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{tithes.ChurchId}-{id}");
            _cache.Remove($"{_cacheKey}-{id}");
            foreach (var item in HashGetByPeriod)
                _cache.Remove(item.Key);
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

    private async Task SaveImageStoreAsync(Tithes model, string fileName, string? base64Image)
    {
        ModelImage serviceImage = new("tithes", fileName, _logger, _storage);
        await serviceImage.SaveImageStoreAsync(base64Image);
    }
}