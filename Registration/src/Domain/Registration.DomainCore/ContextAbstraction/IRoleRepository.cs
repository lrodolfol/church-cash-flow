using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;

public interface IRoleRepository
{
    public Task<List<Role>> Get(int[] id);
    public Task<Role> Get(int id);
}