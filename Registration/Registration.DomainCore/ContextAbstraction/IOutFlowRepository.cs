using Registration.DomainBase.Entities;

namespace Registration.DomainCore.ContextAbstraction;
public interface IOutFlowRepository
{
    public IQueryable<OutFlow>? GetAll();
    public Task<OutFlow> GetOne(int id);
    public Task<OutFlow> GetOneNoTracking(int id);
    public Task Post(OutFlow outFlow);
    public Task Put(OutFlow outFlow);
    public Task Delete(OutFlow outFlow);
}