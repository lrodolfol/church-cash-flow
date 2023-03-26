using DataModelChurchCashFlow.Models.Entities;

namespace DataModelChurchCashFlow.Context.Interface;
public interface IOutFlowContext
{
    public IQueryable<OutFlow>? GetAll(int churchId);
    public Task<OutFlow> GetOne(int id);
    public Task<OutFlow> GetOneNoTracking(int id);
    public Task Post(OutFlow outFlow);
    public Task Put(OutFlow outFlow);
    public Task Delete(OutFlow outFlow);
}