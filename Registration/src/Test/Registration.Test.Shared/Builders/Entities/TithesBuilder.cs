using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class TithesBuilder : BaseBuilderEntitie
{
    public Tithes Get => GetValid();
    private Tithes GetValid()
    {
        DateTime tithesDay = GetValidNearDate();

        Tithes tithes = new(GetRandomInt(),
            GetValidDescription(),
            GetRandomDecimal(),
            tithesDay,
            tithesDay.ToString("yyyy/MM"),
            new ChurchBuilder().Get.Id,
            new MemberBuilder().Get.Id,
            new OfferingBuilder().Get.Id
            );

        return tithes;
    }
}
