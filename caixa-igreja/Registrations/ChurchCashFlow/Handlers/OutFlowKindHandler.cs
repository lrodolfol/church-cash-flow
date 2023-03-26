using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using DataModelChurchCashFlow.Queries;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using ChurchCashFlow.Data.ViewModels.Dtos.OutFlowKind;

namespace ChurchCashFlow.Handlers;
public class OutFlowKindHandler : Handler
{
    private IOutFlowKindContext _context;
    private IMapper _mapper;

    public OutFlowKindHandler(IOutFlowKindContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ResultViewModel<IEnumerable<ReadOutFlowKindDto>>> GetAll(bool active = true)
    {
        try
        {
            var ouFlowKindExpression  = Queries<OutFlowKind>.GetActive(active);

            var outFlowKindQuery = _context.GetAll();
            var outFlowKind = await outFlowKindQuery.Where(ouFlowKindExpression).ToListAsync();

            var outFlowKindReadDto = _mapper.Map<IEnumerable<ReadOutFlowKindDto>>(outFlowKind);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadOutFlowKindDto>>(outFlowKindReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOutFlowKindDto>("Object not found");
            }

            StatusCode = (int)Scode.OK;

            var OfferingKindReadDto = _mapper.Map<ReadOutFlowKindDto>(OfferingKind);
            return new ResultViewModel<ReadOutFlowKindDto>(OfferingKindReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowKindDto>("Internal Error - OT102A");
        }
    }

    public async Task<ResultViewModel<ReadOutFlowKindDto>> Create(EditOutFlowKindDto outFlowKindEditDto)
    {
        outFlowKindEditDto.Validate();
        if (!outFlowKindEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowKindDto>(outFlowKindEditDto.GetNotification());
        }

        try
        {
            var OfferingKind = _mapper.Map<OutFlowKind>(outFlowKindEditDto);

            await _context.Post(OfferingKind)!;

            var newOutFlow = await _context.GetOne(OfferingKind.Id);

            ReadOutFlowKindDto outFlowRead = _mapper.Map<ReadOutFlowKindDto>(newOutFlow);
            StatusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadOutFlowKindDto>(outFlowRead);
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowKindDto>("Request Error. Check the properties - OT103A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOutFlowKindDto>("Object not found");
            }

            await _context.Delete(outFlowKind);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadOutFlowKindDto>();
        }
        catch (DbException ex)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOutFlowKindDto>("Request Error. Check the properties - OT104A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOutFlowKindDto>("Internal Error - OT104B");
        }
    }


}