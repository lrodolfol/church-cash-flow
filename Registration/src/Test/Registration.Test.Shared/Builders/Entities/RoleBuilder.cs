using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
internal class RoleBuilder : BaseBuilderEntitie
{
    public Role Get => GetValid();
    private Role GetValid() =>
        new Role(GetRandomInt(), 
            GetValidCode()
            );
}
