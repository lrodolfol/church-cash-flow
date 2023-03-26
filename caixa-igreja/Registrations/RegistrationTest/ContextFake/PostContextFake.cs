using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;

namespace RegistrationTest.ContextFake;
public class PostContextFake : IPostContext
{
    public static List<Post> Posts { get; private set; } = new();

	public PostContextFake()
	{
		Posts.Add(new Post(1, "Membro", "membro da igreja membro"));
        Posts.Add(new Post(2, "Obreiro", "obreiro da igreja obreiro"));
    }

    public IQueryable<Post>? GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Post> GetOne(int id)
    {
        return Posts.FirstOrDefault(x => x.Id == id);
    }

    public Task<Post> GetOneNoTracking(int id)
    {
        return GetOne(id);
    }

    public Task Post(Post post)
    {
        throw new NotImplementedException();
    }

    public Task Put(Post editPost)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Post post)
    {
        Posts.Remove(post);
    }
}
