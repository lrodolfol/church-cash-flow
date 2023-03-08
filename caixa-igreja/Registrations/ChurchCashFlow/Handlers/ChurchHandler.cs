using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using ChurchCashFlow.Data.ViewModels;
using DataModelChurchCashFlow.Queries;
using DataModelChurchCashFlow.Context.Interface;
using Microsoft.EntityFrameworkCore;
using Scode = System.Net.HttpStatusCode;
using ChurchCashFlow.Data.Entities;
using DataModelChurchCashFlow.Entities;
using System.Data.Common;

namespace ChurchCashFlow.Handlers;
public class ChurchHandler : Handler
{
    private IChurchContext _context;
    private IMapper _mapper;
    
    public ChurchHandler(IChurchContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ResultViewModel<IEnumerable<ReadChurchDto>>> GetAll(bool active = true)
    {
        try
        {
            var churchExpression = ChurchQueries.GetChurchActive(active);

            var churchQuery = _context.GetAll(active);
            var churches = await churchQuery.Where(churchExpression).ToListAsync();

            var churchesReadDto = _mapper.Map<IEnumerable<ReadChurchDto>>(churches);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadChurchDto>>(churchesReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.InternalServerError;
            return new ResultViewModel<IEnumerable<ReadChurchDto>>("Internal Error - CH1101A");
        }
    }

    public async Task<ResultViewModel<ReadChurchDto>> GetOne(int id)
    {
        try
        {
            var church = await _context.GetOne(id);

            if (church == null)
            {
                StatusCode = (int)Scode.NotFound;
                return new ResultViewModel<ReadChurchDto>("Object not found");
            }

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadChurchDto>(churchReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.InternalServerError;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1103A");
        }

    }


    public async Task<ResultViewModel<ReadChurchDto>> Create(ChurchAddress churchEditDto)
    {
        churchEditDto.Validate();
        if (!churchEditDto.IsValid)
        {
            StatusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>(churchEditDto.GetNotification());
        }

        try
        {
            var address = _mapper.Map<Address>(churchEditDto);
            var church = _mapper.Map<Church>(churchEditDto);
            church.AddAddress(address);

            await _context.Post(church);

            var newChurch = await _context.GetOneNoTracking(church.Id);

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(newChurch);

            StatusCode = (int)Scode.Created;
            return new ResultViewModel<ReadChurchDto>(churchReadDto);
        }
        catch (DbException)
        {
            StatusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>("Request Error - CH1105A");
        }
        catch
        {
            StatusCode = (int)Scode.InternalServerError;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1105B");
        }
    }

    public async Task<ResultViewModel<ReadChurchDto>> Update(ChurchAddress churchEditDto, int id)
    {
        churchEditDto.Validate();
        if (!churchEditDto.IsValid)
        {
            StatusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>(churchEditDto.GetNotification());
        }

        try
        {
            var church = await _context.GetOne(id);
            if (church == null)
            {
                StatusCode = (int)Scode.NotFound;
                return new ResultViewModel<ReadChurchDto>("Object not found");
            }

            var editChurch = _mapper.Map<Church>(churchEditDto);
            var editAddress = _mapper.Map<Address>(churchEditDto);

            var address = church.Address;

            address.UpdateChanges(editAddress);
            church.AddAddress(address);
            church.UpdateChanges(editChurch);

            await _context.Put(church);

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadChurchDto>(churchReadDto);
        }
        catch (DbException)
        {
            StatusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>("Request Error - CH1106A");
        }
        catch
        {
            StatusCode = (int)Scode.InternalServerError;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1106B");
        }
    }

    public async Task<ResultViewModel<ReadChurchDto>> Delete(int id)
    {
        try
        {
            var church = await _context.GetOne(id);
            if (church == null)
            {
                StatusCode = (int)Scode.NotFound;
                return new ResultViewModel<ReadChurchDto>("Object not found");
            }

            await _context.Delete(church);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadChurchDto>();
        }
        catch (DbException)
        {
            StatusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1107B");
        }
        catch
        {
            StatusCode = (int)Scode.InternalServerError;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1107C");
        }
    }
}
