using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Serilog;

namespace Registration.Handlers.Handlers.Registrations;

public class MemberPostHandler : BaseNormalHandler
{
    private IMemberPostRepository _context;
    private ILogger _logger;

    public MemberPostHandler(IMapper mapper, CViewModel viewModel, IMemberPostRepository context, ILogger logger) 
        : base(mapper, viewModel)
    {
        _context = context;
        _logger = logger;
    }

    public async Task Create(int userId, int[] postIds)
    {
        var memberPosts = new List<MemberPost>();
        
        memberPosts.AddRange(postIds.Select(x => new MemberPost(userId, x)));

        await _context.Post(memberPosts);
    }

    public async Task Delete(int userId)
    {
        await _context.Delete(userId);
    }
}
