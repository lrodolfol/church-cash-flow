using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChurchCashFlow.Data.Context;
public class OfferingKindContext : IOfferingKindContext
{
    private readonly DataContext _context;

    public OfferingKindContext(DataContext context)
    {
        _context = context;
    }

    public IQueryable<OfferingKind>? GetAll()
    {
        var usersQueryable = _context.OfferingKind.AsQueryable();

        return usersQueryable;
    }

    public async Task<OfferingKind> GetOneAsNoTracking(int id) => await _context.OfferingKind.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    public async Task<OfferingKind> GetOne(int id) => await _context.OfferingKind.FirstOrDefaultAsync(x => x.Id == id);

    public async Task Post(OfferingKind offeringKind)
    {
        await _context.OfferingKind.AddAsync(offeringKind);
        await Save();
    }

    public async Task Delete(OfferingKind OfferingKind)
    {
        OfferingKind.Activate(false);
        await Put(OfferingKind);
    }

    private async Task Put(OfferingKind offeringKind)
    {
        _context.Entry(offeringKind).State = EntityState.Modified;
        await Save();
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
