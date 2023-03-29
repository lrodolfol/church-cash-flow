using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.OutFlow;

namespace ChurchCashFlow.Handlers;
public class OutFlowHanler : IHandlerByChurch<ReadOutFlowDto, EditOutFlowDto>
{
    private IOutFlowRepository _context;
    private IMapper _mapper;
    private int _statusCode;

    public OutFlowHanler(IOutFlowRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public int GetStatusCode() => (int)_statusCode;

    public async Task<ResultViewModel<IEnumerable<ReadOutFlowDto>>> GetAll(int churchId, bool active = true)
    {
        try
        {
            var outFlowExpression = Querie<OutFlow>.GetActive(active);

            var outFlowQuery = _context.GetAll();
            var outFlow = await outFlowQuery
                .Where(outFlowExpression)
                .Where(x => x.ChurchId == churchId)
                .Include(x => x.OutFlowKind)
                .Include(x => x.Church)
                .ToListAsync();

            var outFlowReadDto = _mapper.Map<IEnumerable<ReadOutFlowDto>>(outFlow);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadOutFlowDto>>(outFlowReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<IEnumerable<ReadOutFlowDto>>("Internal Error - OT1101A");
        }
    }

    public async Task<ResultViewModel<ReadOutFlowDto>> GetOne(int id)
    {
        try
        {
            var outFlow = await _context.GetOne(id);
            if (outFlow == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOutFlowDto>("Object not found");
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadOutFlowDto>(outFlow);
            return new ResultViewModel<ReadOutFlowDto>(outFlowReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowDto>("Internal Error - OT1102A");
        }
    }

    public async Task<ResultViewModel<ReadOutFlowDto>> Create(EditOutFlowDto outFlowEditDto)
    {
        outFlowEditDto.Validate();
        if (!outFlowEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>(outFlowEditDto.GetNotification());
        }

        try
        {
            var outFlow = _mapper.Map<OutFlow>(outFlowEditDto);
            outFlow.CalculateTotalAmount();

            //verificar o totalAmount
            await _context.Post(outFlow)!;

            var newOutFlow = await _context.GetOne(outFlow.Id);

            var outFlowReadDto = _mapper.Map<ReadOutFlowDto>(newOutFlow);
            _statusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadOutFlowDto>(outFlowReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>("Request Error. Check the properties - OT1103A");
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowDto>("Internal Error. - OT1103B");
        }
    }

    public async Task<ResultViewModel<ReadOutFlowDto>> Update(EditOutFlowDto outFlowEditDto, int id)
    {
        outFlowEditDto.Validate();
        if (!outFlowEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>(outFlowEditDto.GetNotification());
        }

        try
        {
            var outFlow = await _context.GetOne(id);
            if (outFlow == null)
            {
                _statusCode = 404;
                return new ResultViewModel<ReadOutFlowDto>("Object not found");
            }

            var editOutFlow = _mapper.Map<OutFlow>(outFlowEditDto);
            outFlow.UpdateChanges(editOutFlow);
            
            await _context.Put(outFlow);

            var userReadDto = _mapper.Map<ReadOutFlowDto>(editOutFlow);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadOutFlowDto>();
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>("Request Error. Check the properties - OT1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowDto>("Internal Error. - OT1104B");
        }
    }

    public async Task<ResultViewModel<ReadOutFlowDto>> Delete(int id)
    {
        try
        {
            var otFlow = await _context.GetOne(id);
            if (otFlow == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOutFlowDto>("Object not found");
            }

            await _context.Delete(otFlow);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadOutFlowDto>();
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>("Request Error. Check the properties - OT1105A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowDto>("Internal Error - OT1105B");
        }
    }
}