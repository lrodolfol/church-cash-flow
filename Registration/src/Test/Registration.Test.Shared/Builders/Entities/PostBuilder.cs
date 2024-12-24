using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class PostBuilder : BaseBuilderEntitie
{
    public Post Get => GetValid();
    private Post GetValid() =>
        new Post(GetRandomInt(), 
            GetValidPersonShortName(), 
            GetValidDescription()
            );
}
