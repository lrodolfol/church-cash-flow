using Registration.DomainBase.Entities;

namespace Registration.DomainCore.ContextAbstraction;
public interface ITithesRepository
{
    public IQueryable<Tithes> GetAll(int churchId);
    public Task<Tithes> GetOne(int id);
    public Task<Tithes> GetOneAsNoTracking(int id);
    public Task Post(Tithes tithes);
    public Task Put(Tithes tithes);
    public Task Delete(Tithes tithes);
}