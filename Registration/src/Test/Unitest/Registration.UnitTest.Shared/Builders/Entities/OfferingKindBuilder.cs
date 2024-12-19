using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class OfferingKindBuilder : BaseBuilderEntitie
{
    public OfferingKind Get => GetValid();
    private OfferingKind GetValid() =>
        new OfferingKind(GetRandomInt(),
            GetValidPersonShortName(),
            GetValidDescription()
            );
}
