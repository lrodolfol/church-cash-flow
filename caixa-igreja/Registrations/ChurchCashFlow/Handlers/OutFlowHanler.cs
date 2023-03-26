using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using DataModelChurchCashFlow.Queries;
using ChurchCashFlow.Data.ViewModels.Dtos.OutFlow;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;

namespace ChurchCashFlow.Handlers;
public class OutFlowHanler : Handler
{
    private IOutFlowContext _context;
    private IMapper _mapper;
    public OutFlowHanler(IOutFlowContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ResultViewModel<IEnumerable<ReadOutFlowDto>>> GetAll(int churchId, bool active = true)
    {
        try
        {
            var outFlowExpression = Queries<OutFlow>.GetActive(active);

            var outFlowQuery = _context.GetAll();
            var outFlow = await outFlowQuery
                .Where(outFlowExpression)
                .Where(x => x.ChurchId == churchId)
                .Include(x => x.OutFlowKind)
                .Include(x => x.Church)
                .ToListAsync();

            var outFlowReadDto = _mapper.Map<IEnumerable<ReadOutFlowDto>>(outFlow);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadOutFlowDto>>(outFlowReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOutFlowDto>("Object not found");
            }

            StatusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadOutFlowDto>(outFlow);
            return new ResultViewModel<ReadOutFlowDto>(outFlowReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowDto>("Internal Error - OT1102A");
        }
    }
    public async Task<ResultViewModel<ReadOutFlowDto>> Create(EditOutFlowDto outFlowEditDto)
    {
        outFlowEditDto.Validate();
        if (!outFlowEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
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
            StatusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadOutFlowDto>(outFlowReadDto);
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>("Request Error. Check the properties - OT1103A");
        }
        catch(Exception ex)
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowDto>("Internal Error. - OT1103B");
        }
    }
    public async Task<ResultViewModel<ReadOutFlowDto>> Update(EditOutFlowDto outFlowEditDto, int id)
    {
        outFlowEditDto.Validate();
        if (!outFlowEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>(outFlowEditDto.GetNotification());
        }

        try
        {
            var outFlow = await _context.GetOne(id);
            if (outFlow == null)
            {
                StatusCode = 404;
                return new ResultViewModel<ReadOutFlowDto>("Object not found");
            }

            var editOutFlow = _mapper.Map<OutFlow>(outFlowEditDto);
            outFlow.UpdateChanges(editOutFlow);
            
            await _context.Put(outFlow);

            var userReadDto = _mapper.Map<ReadOutFlowDto>(editOutFlow);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadOutFlowDto>();
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>("Request Error. Check the properties - OT1104A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOutFlowDto>("Object not found");
            }

            await _context.Delete(otFlow);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadOutFlowDto>();
        }
        catch (DbException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowDto>("Request Error. Check the properties - OT1105A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowDto>("Internal Error - OT1105B");
        }
    }
}