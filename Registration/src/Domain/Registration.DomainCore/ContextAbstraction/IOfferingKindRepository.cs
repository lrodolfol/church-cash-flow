using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;
public interface IOfferingKindRepository
{
    public IQueryable<OfferingKind>? GetAll();
    public Task<OfferingKind> GetOne(int id);
    public Task<OfferingKind> GetOneAsNoTracking(int id);
    public Task Post(OfferingKind offeringKind);
    public Task Delete(OfferingKind offeringKind);
}