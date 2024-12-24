using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class OutFlowBuilder : BaseBuilderEntitie
{
    public OutFlow Get => GetValid();
    private OutFlow GetValid()
    {
        DateTime outflowDay = GetValidBeforeDate();

        OutFlow outflow = new(GetRandomInt(),
            outflowDay,
            outflowDay.ToString("yyyy/MM"),
            GetValidDescription(),
            new OutFlowBuilder().Get.Id,
            new ChurchBuilder().Get.Id,
            GetRandomDecimal(),
            GetRandomDecimal(),
            GetRandomDecimal(),
            GetRandomBoolean()
            );

        return outflow;
    }        
}
