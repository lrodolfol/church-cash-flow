using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using System.Collections;

namespace Registration.Repository.Repository.Registration;

public class MemberPostRepository : IMemberPostRepository
{
    private readonly DataContext _context;

    public MemberPostRepository(DataContext context)
    {
        _context = context;
    }

    public async Task Delete(int userId)
    {
        var memberPosts = await GetByUserId(userId);

        foreach (var mPost in memberPosts)
        {
            _context.Remove(mPost);
        }

        await Save();
    }

    public async Task<IEnumerable<MemberPost>> GetByUserId(int userId)
    {
        var memberPosts = (IEnumerable<MemberPost>) await _context
            .MemberPost
            .Where(x => x.Members.Id == userId)
            .ToListAsync();

        return memberPosts;
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
