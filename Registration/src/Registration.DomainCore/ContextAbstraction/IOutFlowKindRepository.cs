using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;
public interface IOutFlowKindRepository
{
    public IQueryable<OutFlowKind>? GetAll();
    public Task<OutFlowKind> GetOne(int id);
    public Task<OutFlowKind> GetOneAsNoTracking(int id);
    public Task Post(OutFlowKind outFlow);
    public Task Delete(OutFlowKind outFlow);
}