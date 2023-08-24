using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Registration.UserRole;
using Serilog;
using System;

namespace Registration.Handlers.Handlers.Registrations;

public class UserRoleHandler : BaseNormalHandler
{
    IUserRoleRepository _context;
    private ILogger _logger;

    public UserRoleHandler(IUserRoleRepository context, IMapper mapper, CViewModel viewMode, ILogger logger) 
        : base(mapper, viewMode, logger)
    {
        _context = context;
    }

    public async Task Create(int userId, int[] roleIds)
    {
        try
        {
            foreach (var roleId in roleIds)
            {
                await _context.Post(new UserRole(userId, roleId));
            }
        }
        catch
        {
        }
    }

    public async Task<bool> Get(int[] roleIds)
    {
        var uRoleExpression = Querie<UserRole>.GetActive(true);

        var uRoleQuery = _context.GetByIds(roleIds);
        var users = await uRoleQuery
            .Where(x => roleIds.Contains(x.Id))
            .Where(uRoleExpression)
            .ToListAsync();

        return (users.Any() && users.Count() == roleIds.Length);
    }

    public async Task Delete(int userId)
    {
        await _context.Delete(userId);
    }
}