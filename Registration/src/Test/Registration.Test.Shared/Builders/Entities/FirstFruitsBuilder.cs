using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class FirstFruitsBuilder : BaseBuilderEntitie
{
    public FirstFruits Get => GetValid();
    private FirstFruits GetValid()
    {
        DateTime fruitDay = GetValidNearDate();

        FirstFruits fruits = new FirstFruits(
            GetRandomInt(),
            GetValidDescription(),
            GetRandomDecimal(),
            fruitDay,
            fruitDay.ToString("yyyy/MM"),
            new ChurchBuilder().Get.Id,
            new MemberBuilder().Get.Id,
            new OfferingKindBuilder().Get.Id
            );

        return fruits;
    }
}
