using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;

public interface IMemberPostRepository
{
    public Task Delete(int userId);
    public Task Post(MemberPost memberPost);
    public Task Post(List<MemberPost> memberPosts);
}