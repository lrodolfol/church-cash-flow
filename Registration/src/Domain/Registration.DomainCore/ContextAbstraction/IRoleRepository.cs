using Registration.DomainBase.Entities.Registrations.sql;

namespace Registration.DomainCore.ContextAbstraction;

public interface IRoleRepository
{
    public Task<List<Role>> Get(int[] id);
    public Task<Role> Get(int id);
}