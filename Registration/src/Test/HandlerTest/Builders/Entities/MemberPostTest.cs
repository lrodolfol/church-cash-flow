using Registration.DomainBase.Entities.Registrations;

namespace HandlersTest.Builders.Entities;

public class MemberPostTest
{
    public static MemberPost ValidObjectOne() =>
        new MemberPost(MemberTest.ValidObjectOne().Id, PostTest.ValidObjectOne().Id);

    public static MemberPost ValidObjectTwo() =>
        new MemberPost(MemberTest.ValidObjectTwo().Id, PostTest.ValidObjectTwo().Id);

    public static MemberPost InvalidObjectOne() =>
        new MemberPost(MemberTest.InValidObjectOne().Id, PostTest.InvalidObjectOne().Id);
}