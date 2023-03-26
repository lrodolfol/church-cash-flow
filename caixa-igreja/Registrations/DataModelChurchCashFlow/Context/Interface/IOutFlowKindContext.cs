using DataModelChurchCashFlow.Models.Entities;

namespace DataModelChurchCashFlow.Context.Interface;
public interface IOutFlowKindContext
{
    public IQueryable<OutFlowKind>? GetAll();
    public Task<OutFlowKind> GetOne(int id);
    public Task<OutFlowKind> GetOneAsNoTracking(int id);
    public Task Post(OutFlowKind outFlow);
    public Task Delete(OutFlowKind outFlow);
}