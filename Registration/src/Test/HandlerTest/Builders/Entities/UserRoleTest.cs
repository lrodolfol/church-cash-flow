using Registration.DomainBase.Entities.Registrations;

namespace HandlersTest.Builders.Entities;

public class UserRoleTest
{
    public static UserRole ValidObjectOne() =>
        new UserRole(UserTest.ValidObjectOne().Id, RoleTest.ValidObjectOne().Id);

    public static UserRole ValidObjectTwo() =>
        new UserRole(UserTest.ValidObjectTwo().Id, RoleTest.ValidObjectTwo().Id);

    public static UserRole ValidObjectThree() =>
        new UserRole(UserTest.ValidObjectThree().Id, RoleTest.ValidObjectThree().Id);

    public static UserRole ValidObjectFour() =>
        new UserRole(UserTest.ValidObjectFour().Id, RoleTest.ValidObjectFour().Id);
}