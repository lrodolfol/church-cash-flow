using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;

public interface IUserRoleRepository
{
    public Task Post(UserRole userRole);
    public IQueryable<UserRole> GetByIds(int[] ids);
}