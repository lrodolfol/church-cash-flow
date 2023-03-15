using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Data.ViewModels.Dtos.User;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using DataModelChurchCashFlow.Queries;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;

namespace ChurchCashFlow.Handlers;
public class UserHandler : Handler
{
    private IUserContext _context;
    private IMapper _mapper;    
    public UserHandler(IUserContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public UserHandler(IUserContext context)
    {
        _context = context;
    }

    public async Task<ResultViewModel<IEnumerable<ReadUserDto>>> GetAll(bool active = true)
    {
        try
        {
            var userExpression = UsersQueries.GetUsersActive(active);

            var usersQuery = _context.GetAll();
            var users = await usersQuery.Where(userExpression).ToListAsync();

            var usersReadDto = _mapper.Map<IEnumerable<ReadUserDto>>(users);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadUserDto>>(usersReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadUserDto>("Object not found");
            }

            StatusCode = (int)Scode.OK;

            var userReadDto = _mapper.Map<ReadUserDto>(user);
            return new ResultViewModel<ReadUserDto>(userReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadUserDto>("Internal Error - US1102A");
        }
    }

    public async Task<ResultViewModel<ReadUserDto>> Create(EditUserDto userEditDto)
    {
        userEditDto.Validate();
        if (!userEditDto.IsValid) {
            StatusCode = (int)Scode.BAD_REQUEST;
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
            StatusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadUserDto>(userReadDto);
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>("Request Error. Check the properties - US1103A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadUserDto>("Internal Error. - US1103B");
        }
    }

    public async Task<ResultViewModel<ReadUserDto>> Update(EditUserDto userEditDto, int id)
    {
        userEditDto.Validate();
        if (!userEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>(userEditDto.GetNotification());
        }

        try
        {
            var user = await _context.GetOne(id);
            if(user == null)
            {
                StatusCode = 404;
                return new ResultViewModel<ReadUserDto>("Object not found");
            }

            var editUser = _mapper.Map<User>(userEditDto);
            user.UpdateChanges(editUser);

            await _context.Put(user);

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(editUser);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadUserDto>(userReadDto);
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>("Request Error. Check the properties - US1104A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadUserDto>("Object not found");
            }

            await _context.Delete(user);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadUserDto>();
        }
        catch (DbException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>("Request Error. Check the properties - US1105A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadUserDto>("Internal Error - US1105B");
        }
    }

}