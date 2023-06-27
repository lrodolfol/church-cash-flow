using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Handlers.Handlers.Registrations;

public class RoleHandler
{
    private readonly IRoleRepository _context;

    public RoleHandler(IRoleRepository context)
    {
        _context = context;
    }

    public async Task<List<Role>> Get(int[] ids) => await _context.Get(ids);
    public async Task<Role> Get(int id) => await _context.Get(id);

}