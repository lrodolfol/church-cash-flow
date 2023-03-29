using AutoMapper;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.OfferingKind;

namespace ChurchCashFlow.Handlers;
public class OfferingKindHandler : IHandler<ReadOfferingKindDto, EditOfferingKindDto>
{
    private IOfferingKindRepository _context;
    private IMapper _mapper;
    private int _statusCode;

    public OfferingKindHandler(IOfferingKindRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public int GetStatusCode() => (int)_statusCode;

    public async Task<ResultViewModel<IEnumerable<ReadOfferingKindDto>>> GetAll(bool active = true)
    {
        try
        {
            var offeringKindExpression  = Querie<OfferingKind>.GetActive(active);

            var offeringKindQuery = _context.GetAll();
            var offeringKind = await offeringKindQuery.Where(offeringKindExpression).ToListAsync();

            var offeringKindReadDto = _mapper.Map<IEnumerable<ReadOfferingKindDto>>(offeringKind);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadOfferingKindDto>>(offeringKindReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOfferingKindDto>("Object not found");
            }

            _statusCode = (int)Scode.OK;

            var OfferingKindReadDto = _mapper.Map<ReadOfferingKindDto>(OfferingKind);
            return new ResultViewModel<ReadOfferingKindDto>(OfferingKindReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOfferingKindDto>("Internal Error - OF102A");
        }
    }

    public async Task<ResultViewModel<ReadOfferingKindDto>> Create(EditOfferingKindDto OfferingKindEditDto)
    {
        OfferingKindEditDto.Validate();
        if (!OfferingKindEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOfferingKindDto>(OfferingKindEditDto.GetNotification());
        }

        try
        {
            var OfferingKind = _mapper.Map<OfferingKind>(OfferingKindEditDto);

            await _context.Post(OfferingKind)!;

            var newOffering = await _context.GetOne(OfferingKind.Id);

            ReadOfferingKindDto offeringReadDto = _mapper.Map<ReadOfferingKindDto>(newOffering);
            _statusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadOfferingKindDto>(offeringReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOfferingKindDto>("Request Error. Check the properties - OF103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadOfferingKindDto>("Object not found");
            }

            await _context.Delete(OfferingKind);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadOfferingKindDto>();
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadOfferingKindDto>("Request Error. Check the properties - OF104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadOfferingKindDto>("Internal Error - OF104B");
        }
    }

    public Task<ResultViewModel<ReadOfferingKindDto>> Update(EditOfferingKindDto churchEditDto, int id)
    {
        //ainda não implementado
        throw new NotImplementedException();
    }
}