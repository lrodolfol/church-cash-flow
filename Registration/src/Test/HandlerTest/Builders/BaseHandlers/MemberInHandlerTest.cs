using HandlersTest.Builders.Entities;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;

namespace HandlersTest.Builders.BaseHandlers;

public class MemberInHandlerTest : HandlerTest
{
    private Mock<IMemberInRepository> repository = null!;
    public MemberInHandlerTest()
    {
        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IMemberInRepository>();

        repository.Setup(x => x.Post(MemberInTest.ValidObjectOne()));
    }

    public MemberInHandler GetHandler() =>
        new MemberInHandler(repository.Object);
}