using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Queries;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.User;
using Registration.Mapper.DTOs.Registration.UserLogin;

namespace Registration.Handlers.Handlers.Registrations;
public class UserHandler : BaseNormalHandler
{
    private IUserRepository _context;

    public UserHandler(IUserRepository context, IMapper mapper, CViewModel viewModel) : base(mapper, viewModel)
    {
        _context = context;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        try
        {
            var userExpression = Querie<User>.GetActive(active);

            var usersQuery = _context.GetAll();
            var users = await usersQuery.Where(userExpression).ToListAsync();

            var usersReadDto = _mapper.Map<IEnumerable<ReadUserDto>>(users);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(usersReadDto);

            return _viewModel;
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - US1101A");
            return _viewModel;
        }
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var userReadDto = _mapper.Map<ReadUserDto>(user);
            _viewModel.SetData(userReadDto);

            return _viewModel;
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - US1102A");

            return _viewModel;
        }
    }

    public async Task<CViewModel> Create(EditUserCreateDto userEditDto)
    {
        userEditDto.Validate();
        if (!userEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(userEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var user = _mapper.Map<User>(userEditDto);
            user.GeneratePassWordHash(user.PasswordHash);
            user.GenerateCode();

            await _context.Post(user)!;

            var newUser = await _context.GetOneNoTracking(user.Id);

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(newUser);
            _statusCode = (int)Scode.CREATED;
            _viewModel.SetData(userReadDto);

            return _viewModel;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - US1103A");

            return _viewModel;
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - US1103B");

            return _viewModel;
        }
    }

    public async Task<CViewModel> Update(EditUserDto userEditDto, int id)
    {
        userEditDto.Validate();
        if (!userEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(userEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            var editUser = _mapper.Map<User>(userEditDto);
            user.UpdateChanges(editUser);

            await _context.Put(user);

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(editUser);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(userReadDto);

            return _viewModel;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - US1104A");

            return _viewModel;
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - US1104B");

            return _viewModel;
        }
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            await _context.Delete(user);

            _statusCode = (int)Scode.OK;
            return _viewModel;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - US1105A");

            return _viewModel;
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - US1105B");

            return _viewModel;
        }
    }

}