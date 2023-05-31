using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Repository;
public class ChurchRepository : IChurchRepository
{
    private readonly DataContext _context;
    private readonly AddressRepository _contextAddress;

    public ChurchRepository(DataContext context, AddressRepository contextAddress)
    {
        _context = context;
        _contextAddress = contextAddress;
    }

    public IQueryable<Church> GetAll(bool active)
    {
        var churchQueryable = _context.Churches.AsNoTracking().Include(x => x.Address).AsQueryable();

        return churchQueryable;
    }

    public async Task<Church> GetOne(int id)
    {
        var church = await _context.Churches.
               Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == id);

        return church;
    }

    public async Task<Church> GetOneNoTracking(int id)
    {
        var church = await _context.Churches.AsNoTracking()
               .Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == id);

        return church;
    }

    public async Task Post(Church church)
    {
        _context.Add(church);
        await Save();
    }

    public async Task Put(Church church)
    {
        _context.Entry(church).State = EntityState.Modified;
        await Save();
    }

    public async Task Delete(Church church)
    {
        church.Activate(false);
        await Put(church);
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}