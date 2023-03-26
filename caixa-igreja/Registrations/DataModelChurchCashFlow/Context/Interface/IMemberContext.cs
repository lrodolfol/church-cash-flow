using DataModelChurchCashFlow.Models.Entities;

namespace DataModelChurchCashFlow.Context.Interface;
public interface IMemberContext
{
    public IQueryable<Member>? GetAllNoTracking();
    public IQueryable<Member>? GetAllForChurch();
    public Task<Member> GetOne(int id);
    public Task<Member> GetByCode(string code);
    public Task<Member> GetOneNoTracking(int id);
    public Task Post(Member editMember);
    public Task Put(Member editMember);
    public Task Delete(Member Member);
}