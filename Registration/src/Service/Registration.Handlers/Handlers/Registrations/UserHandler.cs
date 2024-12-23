﻿using AutoMapper;
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
using Serilog;
using Registration.DomainCore.Events;
using Microsoft.Extensions.Caching.Memory;
using MessageBroker.RabbitMq;

namespace Registration.Handlers.Handlers.Registrations;
public class UserHandler : BaseNormalHandler
{
    private IUserRepository _context;
    private UserRoleHandler _userRoleHandler;
    private RoleHandler _roleHandler;
    private ILogger _logger;
    private readonly RabbitMqBaseEvent _baseMessage;
    private readonly IMemoryCache _cache;
    private const string _cacheKey = "FIRSTFRUITS";

    public UserHandler(IUserRepository context, IMapper mapper, CViewModel viewModel, UserRoleHandler userRoleHandler, RoleHandler roleHandler, ILogger logger, RabbitMqBaseEvent baseMessage, IMemoryCache cache)
        : base(mapper, viewModel)
    {
        _context = context;
        _userRoleHandler = userRoleHandler;
        _roleHandler = roleHandler;
        _logger = logger;
        _baseMessage = baseMessage;
        _cache = cache;
    }

    private void SendNewUserCreated(User user, string passwordNotEncrypt)
    {
        //var @event = new NewUserCreated(EnvironmentConfiguration.ConfigurationRoot);
        _baseMessage.PreparePublish(new UserCreatedEvent(user.Id, user.Email.Address, passwordNotEncrypt));
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        IEnumerable<ReadUserDto>? usersReadDto;

        try
        {
            usersReadDto = await _cache.GetOrCreateAsync(_cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                var userExpression = Querie<User>.GetActive(active);

                var usersQuery = _context.GetAll();
                var users = await usersQuery.Where(userExpression).ToListAsync();

                return _mapper.Map<IEnumerable<ReadUserDto>>(users);
            });

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
        ReadUserDto? userReadDto;

        try
        {
            userReadDto = await _cache.GetOrCreateAsync($"{_cacheKey}-{id}", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;
                var user = await _context.GetOne(id);
                return _mapper.Map<ReadUserDto>(user);
            });
            
            if (userReadDto == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;
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

    public async Task<CViewModel> Create(EditUserCreateDto dto)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        try
        {
            if (! CheckRole(dto))
                return _viewModel;

            var user = _mapper.Map<User>(dto);
            user.SetEmail(dto.Email);
            user.GeneratePassWordHash(user.PasswordHash);
            user.GenerateCode();

            await _context.Post(user)!;

            await CreateUserRole(user.Id, dto.RoleIds.ToArray());

            var newUser = await _context.GetOneNoTracking(user.Id);

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(newUser);
            _statusCode = (int)Scode.CREATED;
            _viewModel.SetData(userReadDto);

            _cache.Remove(_cacheKey);

            SendNewUserCreated(user, dto.PasswordHash);

            return _viewModel;
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - US1103B");
            _logger.Error("Fail - create one {error} - US1103B", ex.Message);
            return _viewModel;
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - US1103C");
            _logger.Error("Fail - create one {error} - US1103B", ex.Message);
            return _viewModel;
        }
    }

    private async Task CreateUserRole(int userId, int[] roleIds)
    {
        await _userRoleHandler.Create(userId, roleIds);
    }

    public async Task<CViewModel> Update(EditUserDto dto, int id)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The user with id {id} was not found", id);
                return _viewModel;
            }

            if (!CheckRole(dto))
                return _viewModel;

            var editUser = _mapper.Map<User>(dto);
            user.UpdateChanges(editUser);

            await _context.Put(user);

            await _userRoleHandler.Delete(user.Id);
            await CreateUserRole(user.Id, dto.RoleIds.ToArray());

            ReadUserDto userReadDto = _mapper.Map<ReadUserDto>(editUser);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(userReadDto);

            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{id}");

            return _viewModel;
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - US1104B");
            _logger.Error("Fail - update {error} - US1104B", ex.Message);
            return _viewModel;
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - US1104C");
            _logger.Error("Fail - update {error} - US1104C", ex.Message);
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
                _logger.Error("The user with id {id} was not found", id);
                return _viewModel;
            }

            await _context.Delete(user);

            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{id}");

            _statusCode = (int)Scode.OK;
            return _viewModel;
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - US1105A");
            _logger.Error("Fail - delete {error} - US1105A", ex.Message);
            return _viewModel;
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - US1105B");
            _logger.Error("Fail - delete {error} - US1105B", ex.Message);
            return _viewModel;
        }
    }

    private bool CheckRole(EditUserCreateDto dto)
    {
        var roles = _roleHandler.Get(dto.RoleIds.ToArray());
        roles.Wait();
        if ((!roles.Result.Any()) || (roles.Result.Count() < dto.RoleIds.ToArray().Length))
        {
            _viewModel.SetErrors("Role creation failure. Role not found - US1103A");
            _statusCode = (int)Scode.BAD_REQUEST;
            _logger.Error("Role with id {id} was not found", dto.RoleIds);
            return false;
        }

        return true;
    }

    private bool CheckRole(EditUserDto dto)
    {
        var roles = _roleHandler.Get(dto.RoleIds.ToArray());
        roles.Wait();
        if ((!roles.Result.Any()) || (roles.Result.Count() < dto.RoleIds.ToArray().Length))
        {
            _viewModel.SetErrors("Role creation failure. Role not found - US1103A");
            _statusCode = (int)Scode.BAD_REQUEST;
            _logger.Error("Role with id {id} was not found", dto.RoleIds);
            return false;
        }

        return true;
    }

}