using DataModelChurchCashFlow.Models.Entities;

namespace DataModelChurchCashFlow.Context.Interface;
public interface IPostContext
{
    public IQueryable<Post>? GetAll();
    public Task<Post> GetOne(int id);
    public Task<Post> GetOneNoTracking(int id);
    public Task Post(Post post);
    public Task Put(Post editPost);
    public Task Delete(Post Post);
}