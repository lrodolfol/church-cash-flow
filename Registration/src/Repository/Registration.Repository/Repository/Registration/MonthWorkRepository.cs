using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Repository.Repository.Registration;

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
        await SaveAsync();
    }

    public async Task Remove(MonthWork monthWork)
    {
        _context.Remove(monthWork);
        await SaveAsync();
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

    private async Task SaveAsync()
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

    public async Task<MonthWork?> GetOneByCompetence(int yearMonth, int churchId)
    {
        var monthW = await _context.MonthWork.Include(x => x.Church)
        .FirstOrDefaultAsync(x => x.ChurchId == churchId && x.YearMonth == yearMonth);

        return monthW;
    }

    public async Task Update(MonthWork monthWork)
    {
        monthWork.Activate(!(bool)monthWork.Active!);
        await SaveAsync();
    }

    public async Task<List<MonthWork>> GetByChurchByYear(int churchId, int year)
    {
        var monthsWork = await _context.MonthWork
            .Where(x => x.ChurchId == churchId && (x.YearMonth.ToString().Substring(0, 4) == year.ToString()))
            .Include(x => x.Church)
            .AsNoTracking()
            .ToListAsync();

        return monthsWork;
    }

    public async Task<List<MonthWork>> GetAllByYear(int year)
    {
        var monthsWork = await _context.MonthWork
        .Where(x => x.YearMonth.ToString().Substring(0, 4) == year.ToString())
        .Include(x => x.Church)
        .OrderBy(x => x.Church!.Name)
        .AsNoTracking()
        .ToListAsync();

        return monthsWork;
    }
}
