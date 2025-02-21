using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class MeetingKindBuilder : BaseBuilderEntitie
{
    public MeetingKind Get => GetValid();
    private MeetingKind GetValid() =>
        new MeetingKind(GetRandomInt(), 
            GetValidPersonShortName(),
            GetValidDescription()
            );
}
