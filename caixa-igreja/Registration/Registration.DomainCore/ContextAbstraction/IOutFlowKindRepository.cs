using Registration.DomainBase.Entities;

namespace Registration.DomainBase.ContextAbstraction;
public interface IOutFlowKindRepository
{
    public IQueryable<OutFlowKind>? GetAll();
    public Task<OutFlowKind> GetOne(int id);
    public Task<OutFlowKind> GetOneAsNoTracking(int id);
    public Task Post(OutFlowKind outFlow);
    public Task Delete(OutFlowKind outFlow);
}