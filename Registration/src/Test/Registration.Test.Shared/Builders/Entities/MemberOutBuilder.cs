using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class MemberOutBuilder : BaseBuilderEntitie
{
    public MemberOut Get => GetValid();
    private MemberOut GetValid() =>
        new MemberOut(new ChurchBuilder().Get.Name!,
            DateOnly.FromDateTime(GetValidNearDate()),
            new MemberBuilder().Get.Id
            );
}
