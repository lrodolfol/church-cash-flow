using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Repository.Repository.Registration;

public class RoleRepository : IRoleRepository
{
    private readonly DataContext _context;

    public RoleRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Role>> Get(int[] ids)
    {
        var roles = await _context.Roles.Where(x => ids.Contains(x.Id)).ToListAsync();

        return roles;
    }

    public async Task<Role>? Get(int id)
    {
        var role = await _context
            .Roles
            .FirstOrDefaultAsync(x => x.Id == id);

        return role;
    }
}
