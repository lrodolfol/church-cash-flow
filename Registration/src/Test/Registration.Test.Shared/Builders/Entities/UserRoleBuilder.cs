
using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class UserRoleBuilder : BaseBuilderEntitie
{
    public UserRole Get => GetValid();
    private UserRole GetValid() =>
        new UserRole(GetRandomInt(),
            new RoleBuilder().Get.Id            
            );
}
