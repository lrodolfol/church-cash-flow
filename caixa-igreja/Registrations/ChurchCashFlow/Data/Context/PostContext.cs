using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;

namespace ChurchCashFlow.Data.Context
{
    public class PostContext : IPostContext
    {
        public Task Delete(Post Post)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Post>? GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetOneNoTracking(int id)
        {
            throw new NotImplementedException();
        }

        public Task Post(Post post)
        {
            throw new NotImplementedException();
        }

        public Task Put(Post editPost)
        {
            throw new NotImplementedException();
        }
    }
}
