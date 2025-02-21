using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class OfferingBuilder : BaseBuilderEntitie
{
    public Offering Get => GetValid();
    private Offering GetValid()
    {
        DateTime offeringDay = GetValidNearDate();

        Offering offergin = new (GetRandomInt(),
            GetValidDescription(),
            offeringDay,
            offeringDay.ToString("yyyy/MM"),
            GetRandomInt(),
            GetRandomInt(),
            GetRandomDecimal(),
            GetValidPersonShortName(),
            new MeetingKindBuilder().Get.Id,
            new OfferingBuilder().Get.Id,
            new ChurchBuilder().Get.Id
            );

        return offergin;
    }
        
}
