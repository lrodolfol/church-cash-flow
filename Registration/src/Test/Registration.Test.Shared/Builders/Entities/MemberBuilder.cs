using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class MemberBuilder : BaseBuilderEntitie
{
    public Member Get => GetValid();
    private Member GetValid() =>
        new Member(GetRandomInt(),
            GetValidPersonFullNameName(),
            GetValidBeforeDate(),
            GetValidBeforeDate(),
            new ChurchBuilder().Get.Id,
            GetValidCode(),
            GetValidBeforeDate()
            );
}
