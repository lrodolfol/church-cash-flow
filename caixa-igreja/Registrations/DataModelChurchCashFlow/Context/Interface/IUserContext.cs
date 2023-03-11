using DataModelChurchCashFlow.Entities;

namespace DataModelChurchCashFlow.Context.Interface;
public interface IUserContext
{
    public IQueryable<User>? GetAll();
    public Task<User> GetOne(int id);
    public Task<User> GetOneNoTracking(int id);
    public Task<User> GetByCode(string code);
    public Task Post(User user);
    public Task Put(User editUser);
    public Task Delete(User user);
}
