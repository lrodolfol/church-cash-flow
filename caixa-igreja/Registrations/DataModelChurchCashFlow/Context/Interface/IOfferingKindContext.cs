using DataModelChurchCashFlow.Models.Entities;

namespace DataModelChurchCashFlow.Context.Interface;
public interface IOfferingKindContext
{
    public IQueryable<OfferingKind>? GetAll();
    public Task<OfferingKind> GetOne(int id);
    public Task<OfferingKind> GetOneAsNoTracking(int id);
    public Task Post(OfferingKind offeringKind);
    public Task Delete(OfferingKind offeringKind);
}