using Registration.DomainBase.Entities.Registrations.sql;

namespace Registration.DomainCore.ContextAbstraction;

public interface IMemberOutRepository
{
    public Task Post(MemberOut memberIn);
    public Task Delete(MemberOut memberIn);
    public Task<MemberOut> GetOneByMemberAsync(int memberId);
}