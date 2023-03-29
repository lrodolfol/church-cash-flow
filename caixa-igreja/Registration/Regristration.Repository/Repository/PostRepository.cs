using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Repository;
public class PostRepository : IPostRepository
{
    private readonly DataContext _context;

    public PostRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Delete(Post Post)
    {
        Post.Activate(false);
        await Put(Post);
    }

    public IQueryable<Post>? GetAll()
    {
        var usersQueryable = _context.Posts.AsQueryable();

        return usersQueryable;
    }

    public async Task<Post> GetOne(int id)
    {
        var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);

        return post;
    }

    public async Task<Post> GetOneNoTracking(int id)
    {
        var post = await _context.Posts.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        return post;
    }

    public async Task Post(Post post)
    {
        _context.Add(post);
        await Save();
    }

    public async Task Put(Post editPost)
    {
        _context.Entry(editPost).State = EntityState.Modified;
        await Save();
    }
    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}