using AutoMapper;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.DomainBase.ContextAbstraction;
using Registration.Mapper.DTOs.OutFlowKind;

namespace ChurchCashFlow.Handlers;
public class OutFlowKindHandler : IHandler<ReadOutFlowKindDto, EditOutFlowKindDto>
{
    private IOutFlowKindRepository _context;
    private IMapper _mapper;
    private int _statusCode;

    public OutFlowKindHandler(IOutFlowKindRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public int GetStatusCode() => (int)_statusCode;

    public async Task<ResultViewModel<IEnumerable<ReadOutFlowKindDto>>> GetAll(bool active = true)
    {
        try
        {
            var ouFlowKindExpression  = Querie<OutFlowKind>.GetActive(active);

            var outFlowKindQuery = _context.GetAll();
            var outFlowKind = await outFlowKindQuery.Where(ouFlowKindExpression).ToListAsync();

            var outFlowKindReadDto = _mapper.Map<IEnumerable<ReadOutFlowKindDto>>(outFlowKind);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadOutFlowKindDto>>(outFlowKindReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<IEnumerable<ReadOutFlowKindDto>>("Internal Error - OT101A");
        }
    }

    public async Task<ResultViewModel<ReadOutFlowKindDto>> GetOne(int id)
    {
        try
        {
            var OfferingKind = await _context.GetOneAsNoTracking(id);
            if (OfferingKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOutFlowKindDto>("Object not found");
            }

            _statusCode = (int)Scode.OK;

            var OfferingKindReadDto = _mapper.Map<ReadOutFlowKindDto>(OfferingKind);
            return new ResultViewModel<ReadOutFlowKindDto>(OfferingKindReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowKindDto>("Internal Error - OT102A");
        }
    }

    public async Task<ResultViewModel<ReadOutFlowKindDto>> Create(EditOutFlowKindDto outFlowKindEditDto)
    {
        outFlowKindEditDto.Validate();
        if (!outFlowKindEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowKindDto>(outFlowKindEditDto.GetNotification());
        }

        try
        {
            var OfferingKind = _mapper.Map<OutFlowKind>(outFlowKindEditDto);

            await _context.Post(OfferingKind)!;

            var newOutFlow = await _context.GetOne(OfferingKind.Id);

            ReadOutFlowKindDto outFlowRead = _mapper.Map<ReadOutFlowKindDto>(newOutFlow);
            _statusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadOutFlowKindDto>(outFlowRead);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowKindDto>("Request Error. Check the properties - OT103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowKindDto>("Internal Error. - OT103B");
        }
    }

    public async Task<ResultViewModel<ReadOutFlowKindDto>> Delete(int id)
    {
        try
        {
            var outFlowKind = await _context.GetOne(id);
            if (outFlowKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOutFlowKindDto>("Object not found");
            }

            await _context.Delete(outFlowKind);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadOutFlowKindDto>();
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowKindDto>("Request Error. Check the properties - OT104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowKindDto>("Internal Error - OT104B");
        }
    }

    public Task<ResultViewModel<ReadOutFlowKindDto>> Update(EditOutFlowKindDto churchEditDto, int id)
    {
        //ainda não implementado
        throw new NotImplementedException();
    }
}