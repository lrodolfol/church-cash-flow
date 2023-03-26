using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using DataModelChurchCashFlow.Queries;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using ChurchCashFlow.Data.ViewModels.Dtos.OfferingKind;

namespace ChurchCashFlow.Handlers;
public class OfferingKindHandler : Handler
{
    private IOfferingKindContext _context;
    private IMapper _mapper;

    public OfferingKindHandler(IOfferingKindContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ResultViewModel<IEnumerable<ReadOfferingKindDto>>> GetAll(bool active = true)
    {
        try
        {
            var offeringKindExpression  = Queries<OfferingKind>.GetActive(active);

            var offeringKindQuery = _context.GetAll();
            var offeringKind = await offeringKindQuery.Where(offeringKindExpression).ToListAsync();

            var offeringKindReadDto = _mapper.Map<IEnumerable<ReadOfferingKindDto>>(offeringKind);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadOfferingKindDto>>(offeringKindReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<IEnumerable<ReadOfferingKindDto>>("Internal Error - OF101A");
        }
    }

    public async Task<ResultViewModel<ReadOfferingKindDto>> GetOne(int id)
    {
        try
        {
            var OfferingKind = await _context.GetOneAsNoTracking(id);
            if (OfferingKind == null)
            {
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOfferingKindDto>("Object not found");
            }

            StatusCode = (int)Scode.OK;

            var OfferingKindReadDto = _mapper.Map<ReadOfferingKindDto>(OfferingKind);
            return new ResultViewModel<ReadOfferingKindDto>(OfferingKindReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOfferingKindDto>("Internal Error - OF102A");
        }
    }

    public async Task<ResultViewModel<ReadOfferingKindDto>> Create(EditOfferingKindDto OfferingKindEditDto)
    {
        OfferingKindEditDto.Validate();
        if (!OfferingKindEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOfferingKindDto>(OfferingKindEditDto.GetNotification());
        }

        try
        {
            var OfferingKind = _mapper.Map<OfferingKind>(OfferingKindEditDto);

            await _context.Post(OfferingKind)!;

            var newOffering = await _context.GetOne(OfferingKind.Id);

            ReadOfferingKindDto offeringReadDto = _mapper.Map<ReadOfferingKindDto>(newOffering);
            StatusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadOfferingKindDto>(offeringReadDto);
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOfferingKindDto>("Request Error. Check the properties - OF103A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOfferingKindDto>("Internal Error. - OF103B");
        }
    }

    public async Task<ResultViewModel<ReadOfferingKindDto>> Delete(int id)
    {
        try
        {
            var OfferingKind = await _context.GetOne(id);
            if (OfferingKind == null)
            {
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOfferingKindDto>("Object not found");
            }

            await _context.Delete(OfferingKind);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadOfferingKindDto>();
        }
        catch (DbException ex)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOfferingKindDto>("Request Error. Check the properties - OF104A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOfferingKindDto>("Internal Error - OF104B");
        }
    }


}