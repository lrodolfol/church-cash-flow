using Registration.DomainBase.Aggregate;
using Registration.DomainBase.Entities.Registrations;

namespace HandlersTest.Builders.Entities;

public class UserTest
{
    public static User ValidObjectOne() =>
        new User(1, "Alberto Junqueira", ChurchTest.ValidObjectOne().Id);

    public static User ValidObjectTwo() =>
        new User(2, "Ivan Roberto", ChurchTest.ValidObjectTwo().Id);

    public static User ValidObjectThree() =>
        new User(3, "Renan Siqueia", ChurchTest.ValidObjectTwo().Id);

    public static User ValidObjectFour() =>
    new User(4, "Beijamin da Silva", ChurchTest.ValidObjectOne().Id);
}
