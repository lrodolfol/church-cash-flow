using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Repository;
public class FirstFruitsRepository : IFirstFruitsRepository
{
    private readonly DataContext _context;

    public FirstFruitsRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Delete(FirstFruits fruits)
    {
        fruits.Activate(false);
        await Put(fruits);
    }

    public IQueryable<FirstFruits> GetAll(int churchId)
    {
        var fruitsQueriable = _context.FirstFruits
            .AsQueryable()
            .Where(x => x.ChurchId == churchId);

        return fruitsQueriable;
    }

    public async Task<FirstFruits> GetOne(int id)
    {
        var fruits = await _context.FirstFruits
            .Include(x => x.Church)
            .Include(x => x.OfferingKind)
            .Include(x => x.Member)
            .FirstOrDefaultAsync(x => x.Id == id);

        return fruits;
    }

    public async Task<FirstFruits> GetOneAsNoTracking(int id)
    {
        var fruits = await _context.FirstFruits
            .Include(x => x.Church)
            .Include(x => x.OfferingKind)
            .Include(x => x.Member)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        return fruits;
    }

    public async Task<FirstFruits?> GetOneNoTracking(int id)
    {
        var fruits = await _context.FirstFruits
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        return fruits;
    }

    public async Task Post(FirstFruits fruits)
    {
        _context.Add(fruits);
        await Save();
    }

    public async Task Put(FirstFruits fruits)
    {
        _context.Entry(fruits).State = EntityState.Modified;
        await Save();
    }
    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}