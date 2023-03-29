using Registration.DomainBase.Entities;

namespace Registration.DomainBase.ContextAbstraction;
public interface IPostRepository
{
    public IQueryable<Post>? GetAll();
    public Task<Post> GetOne(int id);
    public Task<Post> GetOneNoTracking(int id);
    public Task Post(Post post);
    public Task Put(Post editPost);
    public Task Delete(Post Post);
}