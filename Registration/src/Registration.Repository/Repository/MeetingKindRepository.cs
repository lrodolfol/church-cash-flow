using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Repository;
public class MeetingKindRepository : IMeetingKindRepository
{
    private readonly DataContext _context;

    public MeetingKindRepository(DataContext context)
    {
        _context = context;
    }

    public IQueryable<MeetingKind>? GetAll()
    {
        var usersQueryable = _context.MeetingKind.AsQueryable();

        return usersQueryable;
    }

    public async Task<MeetingKind> GetOneAsNoTracking(int id) => await _context.MeetingKind.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    public async Task<MeetingKind> GetOne(int id) => await _context.MeetingKind.FirstOrDefaultAsync(x => x.Id == id);

    public async Task Post(MeetingKind MeetingKind)
    {
        await _context.MeetingKind.AddAsync(MeetingKind);
        await Save();
    }

    public async Task Delete(MeetingKind meetingKind)
    {
        meetingKind.Activate(false);
        await Put(meetingKind);
    }

    private async Task Put(MeetingKind meetingKind)
    {
        _context.Entry(meetingKind).State = EntityState.Modified;
        await Save();
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
