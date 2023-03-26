using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;

namespace RegistrationTest.ContextFake;
public class OutFlowContextFake : IOutFlowContext
{
    public static List<OutFlow> OutFlows { get; set; } = new();
    private List<OutFlowKind> OutFlowsKind { get; set; } = new();

    public async Task Delete(OutFlow outFlow)
    {
        OutFlows.Remove(outFlow);   
    }

    public IQueryable<OutFlow>? GetAll(int churchId)
    {
        return OutFlows.AsQueryable().Where(x => x.ChurchId == churchId);
    }

    public async Task<OutFlow> GetOne(int id)
    {
        return OutFlows.FirstOrDefault(x => x.Id == id);
    }

    public Task<OutFlow> GetOneNoTracking(int id)
    {
        return GetOne(id);
    }

    public async Task Post(OutFlow outFlow)
    {
        OutFlows.Add(outFlow);
    }

    public Task Put(OutFlow outFlow)
    {
        throw new NotImplementedException();
    }
}
