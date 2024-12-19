using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class ChurchBuilder : BaseBuilderEntitie
{
    public Church Get => GetValid();
    private Church GetValid() =>
        new Church(GetRandomInt(), 
            GetValidPersonFullNameName(), 
            GetValidNearDate(), 
            GetValidNearDate(), 
            new AdressBuilder().Get.Id,
            GetValidPersonFullNameName()
            );
}
