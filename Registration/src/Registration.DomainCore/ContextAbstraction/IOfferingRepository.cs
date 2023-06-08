using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;
public interface IOfferingRepository
{
    public IQueryable<Offering> GetAll(int churchId);
    public Task<Offering> GetOne(int id);
    public Task<Offering> GetOneAsNoTracking(int id);
    public Task Post(Offering offering);
    public Task Put(Offering offering);
    public Task Delete(Offering offering);
}