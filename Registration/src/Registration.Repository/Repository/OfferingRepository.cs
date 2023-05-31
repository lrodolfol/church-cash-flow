using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.Mapper.DTOs.Offering;

namespace Registration.Repository.Repository;
public class OfferingRepository : IOfferingRepository
{
    private readonly DataContext _context;

    public OfferingRepository(DataContext context)
    {
        _context = context;
    }

    public IQueryable<Offering>? GetAll(int churchId)
    {
        var offeringQueryable = _context.Offering
            .Where(x => x.ChurchId == churchId)
            .AsNoTracking()
            .AsQueryable();

        return offeringQueryable;
    }

    public async Task<Offering> GetOne(int id)
    {
        var offering = await _context.Offering.
            Include(x => x.Church)
            .Include(x => x.MeetingKind)
            .Include(x => x.OfferingKind)
            .Include(x => x.Church)
            .FirstOrDefaultAsync(x => x.Id == id);

        return offering;
    }

    public async Task<Offering> GetOneAsNoTracking(int id)
    {
        var offering = await _context.Offering.
            Include(x => x.Church)
            .Include(x => x.MeetingKind)
            .Include(x => x.OfferingKind)
            .Include(x => x.Church)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        return offering;
    }

    public async Task Post(Offering offering)
    {
        _context.Add(offering);
        await Save();
    }

    public async Task Put(Offering offering)
    {
        _context.Entry(offering).State = EntityState.Modified;
        await Save();
    }
    public async Task Delete(Offering offering)
    {
        offering.Activate(false);
        await Put(offering);
    }
    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}