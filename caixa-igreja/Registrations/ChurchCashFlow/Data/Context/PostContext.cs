using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChurchCashFlow.Data.Context
{
    public class PostContext : IPostContext
    {
        private readonly DataContext _context;

        public PostContext(DataContext context)
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
}
