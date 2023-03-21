using DataModelChurchCashFlow.Models.Entities;

namespace DataModelChurchCashFlow.Context.Interface;
public interface IChurchContext
{
    public IQueryable<Church>? GetAll(bool active);
    public Task<Church> GetOne(int id);
    public Task<Church> GetOneNoTracking(int id);
    public Task Post(Church church);
    public Task Put(Church church);
    public Task Delete(Church church);
}
