using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;
public interface IMemberRepository
{
    public IQueryable<Member>? GetAllNoTracking();
    public IQueryable<Member>? GetAllForChurch();
    public IQueryable<Member>? GetAllForChurchByMonth();
    public Task<Member> GetOne(int id);
    public Task<Member> GetByCode(string code);
    public Task<Member> GetOneNoTracking(int id);
    public Task Post(Member editMember);
    public Task Put(Member editMember);
    public Task Delete(Member Member);
}