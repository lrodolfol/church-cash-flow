using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Repository.Registration;
public class TithesRepository : ITithesRepository
{
    private readonly DataContext _context;

    public TithesRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Delete(Tithes tithes)
    {
        tithes.Activate(false);
        await Put(tithes);
    }
    public IQueryable<Tithes>? GetAll(int churchId)
    {
        var tithesQueriable = _context.Tithes
            .AsQueryable()
            .Where(x => x.ChurchId == churchId);

        return tithesQueriable;
    }
    public async Task<Tithes> GetOne(int id)
    {
        var tithes = await _context.Tithes
            .Include(x => x.Church)
            .Include(x => x.OfferingKind)
            .Include(x => x.Member)
            .FirstOrDefaultAsync(x => x.Id == id);

        return tithes;
    }

    public async Task<Tithes> GetOneByChurch(int churchId, int id)
    {
        var tithes = await _context.Tithes
            .Include(x => x.Church)
            .Include(x => x.OfferingKind)
            .Include(x => x.Member)
            .SingleOrDefaultAsync(x => x.ChurchId == churchId && x.Id == id);

        return tithes;
    }
    public async Task<Tithes> GetOneAsNoTracking(int id)
    {
        var tithes = await _context.Tithes
            .Include(x => x.Church)
            .Include(x => x.OfferingKind)
            .Include(x => x.Member)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        return tithes;
    }
    public async Task Post(Tithes tithes)
    {
        _context.Add(tithes);
        await Save();
    }
    public async Task Put(Tithes tithes)
    {
        _context.Entry(tithes).State = EntityState.Modified;
        await Save();
    }
    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}