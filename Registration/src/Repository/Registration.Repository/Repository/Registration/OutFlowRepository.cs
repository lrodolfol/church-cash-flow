using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Repository.Registration;
public class OutFlowRepository : IOutFlowRepository
{
    private readonly DataContext _context;

    public OutFlowRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Delete(OutFlow outFlow)
    {
        outFlow.Activate(false);
        await Put(outFlow);
    }

    public IQueryable<OutFlow>? GetAll()
    {
        var outFlowQueriable = _context.OutFlow
            .AsQueryable();

        return outFlowQueriable;
    }

    public async Task<OutFlow> GetOne(int id)
    {
        var outFlow = await _context.OutFlow
            .Include(x => x.Church)
            .Include(x => x.OutFlowKind)
            .FirstOrDefaultAsync(x => x.Id == id);

        return outFlow;
    }

    public async Task<List<OutFlow>> GetAllByMonth(string yearMonth, int id)
    {
        var competence = $"{yearMonth.Substring(0, 4)}-{yearMonth.Substring(4, 2)}-01";


        var outFlow = await _context.OutFlow
            .Include(x => x.Church)
            .Include(x => x.OutFlowKind)
            .Where(x => x.Day.Year == DateTime.Parse(competence).Year && x.Day.Month == DateTime.Parse(competence).Month && x.ChurchId == id)
            .ToListAsync();

        return outFlow;
    }

    public async Task<OutFlow> GetOneNoTracking(int id)
    {
        var outFlow = await _context.OutFlow
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        return outFlow;
    }

    public async Task Post(OutFlow outFlow)
    {
        _context.Add(outFlow);
        await Save();
    }

    public async Task Put(OutFlow editOutFlow)
    {
        _context.Entry(editOutFlow).State = EntityState.Modified;
        await Save();
    }
    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}