using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class UserBuilder : BaseBuilderEntitie
{
    public User Get => GetValid();
    private User GetValid() =>
        new User(GetRandomInt(),
            GetValidPersonShortName(),
            new ChurchBuilder().Get.Id
            );
}
