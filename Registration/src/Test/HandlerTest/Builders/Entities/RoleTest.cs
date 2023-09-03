using Registration.DomainBase.Entities.Registrations;

namespace HandlersTest.Builders.Entities;

public class RoleTest : HandlerTest
{
    public static Role ValidObjectOne() =>
        new Role(1, "L-SCT");

    public static Role ValidObjectTwo() =>
        new Role(2, "L-TRS");

    public static Role ValidObjectThree() =>
        new Role(3, "M-SCT");

    public static Role ValidObjectFour() =>
        new Role(4, "M-TRS");

    public static int[] ValidSomeIdObject() =>
        new int[] { ValidObjectOne().Id, ValidObjectTwo().Id, ValidObjectThree().Id };

    public static List<Role> ValidSomeObject() =>
        new List<Role> { ValidObjectOne(), ValidObjectTwo(), ValidObjectThree() };

}