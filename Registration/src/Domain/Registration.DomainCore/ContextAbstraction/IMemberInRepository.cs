using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;

public interface IMemberInRepository
{
    public Task Post(MemberIn memberIn);
    public Task Delete(MemberIn memberIn);
    public Task<MemberIn> GetOneByMemberAsync(int memberId);
}