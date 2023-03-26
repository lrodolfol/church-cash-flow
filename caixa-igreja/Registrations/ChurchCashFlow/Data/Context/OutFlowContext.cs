using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChurchCashFlow.Data.Context
{
    public class OutFlowContext : IOutFlowContext
    {
        private readonly DataContext _context;

        public OutFlowContext(DataContext context)
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
}
