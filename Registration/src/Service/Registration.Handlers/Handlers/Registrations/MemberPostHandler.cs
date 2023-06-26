using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.Handlers.Handlers.Registrations;

public class MemberPostHandler : BaseNormalHandler
{
    private IMemberPostRepository _context;

    public MemberPostHandler(IMapper mapper, CViewModel viewModel, IMemberPostRepository context) : base(mapper, viewModel)
    {
        _context = context;
    }

    public async Task Create(int userId, int[] postIds)
    {
        var memberPosts = new List<MemberPost>();
        
        memberPosts.AddRange(postIds.Select(x => new MemberPost(userId, x)));

        await _context.Post(memberPosts);
    }
}
