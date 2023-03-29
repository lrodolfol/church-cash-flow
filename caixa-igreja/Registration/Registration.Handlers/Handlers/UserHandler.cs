using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainBase.Entities;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.User;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers;
public class UserHandler : IHandler<ReadUserDto, EditUserDto>
{
    private IUserRepository _context;
    private IMapper _mapper;
    private int _statusCode;
    public UserHandler(IUserRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public int GetStatusCode() => (int)_statusCode;

    public async Task<ResultViewModel<IEnumerable<ReadUserDto>>> GetAll(bool active = true)
    {
        try
        {
            var userExpression = Querie<User>.GetActive(active);

            var usersQuery = _context.GetAll();
            var users = await usersQuery.Where(userExpression).ToListAsync();

            var usersReadDto = _mapper.Map<IEnumerable<ReadUserDto>>(users);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadUserDto>>(usersReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<IEnumerable<ReadUserDto>>("Internal Error - US1101A");
        }
    }

    public async Task<ResultViewModel<ReadUserDto>> GetOne(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadUserDto>("Object not found");
            }

            _statusCode = (int)Scode.OK;

            var userReadDto = _mapper.Map<ReadUserDto>(user);
            return new ResultViewModel<ReadUserDto>(userReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadUserDto>("Internal Error - US1102A");
        }
    }

    public async Task<ResultViewModel<ReadUserDto>> Create(EditUserDto userEditDto)
    {
        userEditDto.Validate();
        if (!userEditDto.IsValid) {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>(userEditDto.GetNotification());
        }

        try
        {
            var user = _mapper.Map<User>(userEditDto);
            user.GeneratePassWordHash(user.PassWord);
            user.GenerateCode();

            await _context.Post(user)!;

            var newUser = await _context.GetOneNoTracking(user.Id);

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(newUser);
            _statusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadUserDto>(userReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>("Request Error. Check the properties - US1103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadUserDto>("Internal Error. - US1103B");
        }
    }

    public async Task<ResultViewModel<ReadUserDto>> Update(EditUserDto userEditDto, int id)
    {
        userEditDto.Validate();
        if (!userEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>(userEditDto.GetNotification());
        }

        try
        {
            var user = await _context.GetOne(id);
            if(user == null)
            {
                _statusCode = 404;
                return new ResultViewModel<ReadUserDto>("Object not found");
            }

            var editUser = _mapper.Map<User>(userEditDto);
            user.UpdateChanges(editUser);

            await _context.Put(user);

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(editUser);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadUserDto>(userReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>("Request Error. Check the properties - US1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadUserDto>("Internal Error. - US1104B");
        }
    }

    public async Task<ResultViewModel<ReadUserDto>> Delete(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadUserDto>("Object not found");
            }

            await _context.Delete(user);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadUserDto>();
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>("Request Error. Check the properties - US1105A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadUserDto>("Internal Error - US1105B");
        }
    }
}