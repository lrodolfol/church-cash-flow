using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Registration.UserRole;
using System;

namespace Registration.Handlers.Handlers.Registrations;

public class UserRoleHandler : BaseNormalHandler
{
    IUserRoleRepository _context;


    public UserRoleHandler(IUserRoleRepository context, IMapper mapper, CViewModel viewMode) : base (mapper, viewMode)
    {
        _context = context;
    }

    public async Task Create(int userId, HashSet<int> roleIds)
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
        var users = await uRoleQuery.Where(uRoleExpression).ToListAsync();

        return users.Any();
    }

}