using HandlersTest.Builders.Entities;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;

namespace HandlersTest.Builders.BaseHandlers;

public class MemberOutHandlerTest : HandlerTest
{
    private Mock<IMemberOutRepository> repository = null!;
    public MemberOutHandlerTest()
    {
        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IMemberOutRepository>();

        repository.Setup(x => x.Post(MemberOutTest.ValidObjectOne()));
    }

    public MemberOutHandler GetHandler() =>
        new MemberOutHandler(repository.Object);
}