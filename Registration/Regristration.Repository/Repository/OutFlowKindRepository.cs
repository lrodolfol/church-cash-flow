using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Repository;
public class OutFlowKindRepository : IOutFlowKindRepository
{
    private readonly DataContext _context;

    public OutFlowKindRepository(DataContext context)
    {
        _context = context;
    }

    public IQueryable<OutFlowKind>? GetAll()
    {
        var usersQueryable = _context.OutFlowKind.AsQueryable();

        return usersQueryable;
    }

    public async Task<OutFlowKind> GetOneAsNoTracking(int id) => await _context.OutFlowKind.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    public async Task<OutFlowKind> GetOne(int id) => await _context.OutFlowKind.FirstOrDefaultAsync(x => x.Id == id);

    public async Task Post(OutFlowKind outFlowKind)
    {
        await _context.OutFlowKind.AddAsync(outFlowKind);
        await Save();
    }

    public async Task Delete(OutFlowKind outFlowKind)
    {
        outFlowKind.Activate(false);
        await Put(outFlowKind);
    }

    private async Task Put(OutFlowKind outFlowKind)
    {
        _context.Entry(outFlowKind).State = EntityState.Modified;
        await Save();
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
