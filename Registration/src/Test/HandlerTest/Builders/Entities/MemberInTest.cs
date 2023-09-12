using Registration.DomainBase.Entities.Registrations;

namespace HandlersTest.Builders.Entities;

public class MemberInTest
{
    public static MemberIn ValidObjectOne() =>
        new MemberIn(ChurchTest.ValidObjectOne().Name!, PostTest.ValidObjectOne().Name!, "Com carta", MemberTest.ValidObjectOne().Id);
    public static MemberIn ValidObjectTwo() =>
    new MemberIn(ChurchTest.ValidObjectTwo().Name!, PostTest.ValidObjectTwo().Name!, "Com carta", MemberTest.ValidObjectTwo().Id);
}