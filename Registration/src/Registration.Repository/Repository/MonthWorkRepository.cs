using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Repository.Repository;

public class MonthWorkRepository : IMonthWorkRepository
{
    private readonly DataContext _context;

    public MonthWorkRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Create(MonthWork monthWork)
    {
        await _context.AddAsync(monthWork);
        await Save();
    }

    public async Task Remove(MonthWork monthWork)
    {
        _context.Remove(monthWork);
        await Save();
    }

    public IQueryable<MonthWork> GetAll(int churchId)
    {
        var monthWorks = _context.MonthWork
            .Where(x => x.ChurchId == churchId)
            .Include(x => x.Church)
            .AsNoTracking()
            .AsQueryable();

        return monthWorks;
    }

    public async Task<MonthWork?> GetOne(int id)
    {
        var monthWork = await _context.MonthWork
           .Include(x => x.Church)
           .FirstOrDefaultAsync(x => x.Id == id);

        return monthWork;
    }

    public async Task<MonthWork?> GetOneAsNoTracking(int id)
    {
        var monthWork = await _context.MonthWork
           .Include(x => x.Church)
           .FirstOrDefaultAsync(x => x.Id == id);

        return monthWork;
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<MonthWork?> GetOneByCompetenceAsNoTracking(int yearMonth, int churchId)
    {
        var monthW = await _context.MonthWork.Include(x => x.Church)
        .AsNoTracking()
        .FirstOrDefaultAsync(x => x.ChurchId == churchId && x.YearMonth == yearMonth);        

        return monthW;
    }
}
