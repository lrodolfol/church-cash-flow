using AutoMapper;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Registration.Handlers.Queries;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.OutFlowKind;
using Serilog;
using Microsoft.Extensions.Caching.Memory;

namespace Registration.Handlers.Handlers.Registrations;
public class OutFlowKindHandler : BaseNormalHandler
{
    private IOutFlowKindRepository _context;
    private ILogger _logger;
    private readonly IMemoryCache _cache;
    private const string _cacheKey = "OUTFLOWSKIND";

    public OutFlowKindHandler(IOutFlowKindRepository context, IMapper mapper, CViewModel viewModel, ILogger logger, IMemoryCache cache)
        : base(mapper, viewModel)
    {
        _context = context;
        _logger = logger;
        _cache = cache;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        IEnumerable<ReadOutFlowKindDto>? outFlowKindReadDto;

        try
        {
            outFlowKindReadDto = await _cache.GetOrCreateAsync(_cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                var ouFlowKindExpression = Querie<OutFlowKind>.GetActive(active);

                var outFlowKindQuery = _context.GetAll();
                var outFlowKind = await outFlowKindQuery.Where(ouFlowKindExpression).ToListAsync();

                return _mapper.Map<IEnumerable<ReadOutFlowKindDto>>(outFlowKind);
            });

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(outFlowKindReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - OT101A");
            _logger.Error("Fail get all {error} - OT101A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        ReadOutFlowKindDto? OfferingKindReadDto;
        OutFlowKind? OfferingKind;
        try
        {
            OfferingKindReadDto = await _cache.GetOrCreateAsync($"{_cacheKey}-{id}", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                OfferingKind = await _context.GetOneAsNoTracking(id);
                return _mapper.Map<ReadOutFlowKindDto>(OfferingKind);
            });
            
            if (OfferingKindReadDto == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The kind with id {id} was not found", id);

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(OfferingKindReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - OT102A");
            _logger.Error("Fail get one {error} - OT102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditOutFlowKindDto outFlowKindEditDto)
    {
        outFlowKindEditDto.Validate();
        if (!outFlowKindEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(outFlowKindEditDto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        try
        {
            var OfferingKind = _mapper.Map<OutFlowKind>(outFlowKindEditDto);

            await _context.Post(OfferingKind)!;

            var newOutFlow = await _context.GetOne(OfferingKind.Id);

            ReadOutFlowKindDto outFlowRead = _mapper.Map<ReadOutFlowKindDto>(newOutFlow);
            _statusCode = (int)Scode.CREATED;
            _viewModel.SetData(outFlowRead);

            _cache.Remove(_cacheKey);
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - OT103A");
            _logger.Error("Fail - create {error} - OT103A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error. - OT103B");
            _logger.Error("Fail - create {error} - OT103B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var outFlowKind = await _context.GetOne(id);
            if (outFlowKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The kind with id {id} was not found", id);
                return _viewModel;
            }

            await _context.Delete(outFlowKind);

            _statusCode = (int)Scode.OK;
            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{id}");
            
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - OT104A");
            _logger.Error("Fail - update {error} - OT104A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - OT104B");
            _logger.Error("Fail - update {error} - OT104B", ex.Message);
        }

        return _viewModel;
    }

}