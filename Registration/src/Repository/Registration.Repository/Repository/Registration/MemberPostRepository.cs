using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;

namespace Registration.Repository.Repository.Registration;

public class MemberPostRepository : IMemberPostRepository
{
    private readonly DataContext _context;

    public MemberPostRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Post(MemberPost memberPost)
    {
        await _context.AddAsync(memberPost);
        await Save();
    }

    public async Task Post(List<MemberPost> memberPosts)
    {
        memberPosts.ForEach(
            memberPost =>
            {
                _context.Add(memberPost);
            }
           );

        await Save();   
    }

    private async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
