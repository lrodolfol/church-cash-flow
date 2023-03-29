using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = System.Net.HttpStatusCode;
using System.Data.Common;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Church;
using Registration.Mapper.DTOs.ChurchAddress;

namespace ChurchCashFlow.Handlers;
public class ChurchHandler : IHandler<ReadChurchDto, ChurchAddress>
{
    private IChurchRepository _context;
    private IMapper _mapper;
    private int _statusCode;

    public ChurchHandler(IChurchRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public int GetStatusCode() => (int)_statusCode;
    public async Task<ResultViewModel<IEnumerable<ReadChurchDto>>> GetAll(bool active = true)
    {
        try
        {
            var churchExpression = Querie<Church>.GetActive(active);

            var churchQuery = _context.GetAll(active);
            var churches = await churchQuery.Where(churchExpression).ToListAsync();

            var churchesReadDto = _mapper.Map<IEnumerable<ReadChurchDto>>(churches);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadChurchDto>>(churchesReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
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
                _statusCode = (int)Scode.NotFound;
                return new ResultViewModel<ReadChurchDto>("Object not found");
            }

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadChurchDto>(churchReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1103A");
        }

    }

    public async Task<ResultViewModel<ReadChurchDto>> Create(ChurchAddress churchEditDto)
    {
        churchEditDto.Validate();
        if (!churchEditDto.IsValid)
        {
            _statusCode = (int)Scode.BadRequest;
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

            _statusCode = (int)Scode.Created;
            return new ResultViewModel<ReadChurchDto>(churchReadDto);
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>("Request Error - CH1105A");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1105B");
        }
    }

    public async Task<ResultViewModel<ReadChurchDto>> Update(ChurchAddress churchEditDto, int id)
    {
        churchEditDto.Validate();
        if (!churchEditDto.IsValid)
        {
            _statusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>(churchEditDto.GetNotification());
        }

        try
        {
            var church = await _context.GetOne(id);
            if (church == null)
            {
                _statusCode = (int)Scode.NotFound;
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

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadChurchDto>(churchReadDto);
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>("Request Error - CH1106A");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
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
                _statusCode = (int)Scode.NotFound;
                return new ResultViewModel<ReadChurchDto>("Object not found");
            }

            await _context.Delete(church);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadChurchDto>();
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BadRequest;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1107B");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            return new ResultViewModel<ReadChurchDto>("Internal Error - CH1107C");
        }
    }

    public async Task<ResultViewModel<List<string>>> GetMembers(IMemberRepository memberContext, int churchId)
    {
        var members = await memberContext.GetAllForChurch()
            .Where(x => x.ChurchId == churchId)
            .OrderBy(x => x.Name)
            .ToListAsync();

        var listMembers = new List<string>();
        members.ForEach(x => listMembers.Add(x.Name));
        
        return new ResultViewModel<List<string>>(listMembers, null);
    }
}
