using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class MemberPostBuilder : BaseBuilderEntitie
{
    public MemberPost Get => GetValid();
    private MemberPost GetValid() =>
        new MemberPost(GetRandomInt(),
            new PostBuilder().Get.Id
            );
}
