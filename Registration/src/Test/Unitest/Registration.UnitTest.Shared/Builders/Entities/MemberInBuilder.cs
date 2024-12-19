using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class MemberInBuilder : BaseBuilderEntitie
{
    public MemberIn Get => GetValid();
    private MemberIn GetValid() =>
        new MemberIn(new ChurchBuilder().Get.Name!,
            GetValidDescription(),
            GetValidDescription(),
            new MemberBuilder().Get.Id
            );
}
