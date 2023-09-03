using HandlersTest.Builders.Entities;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;

namespace HandlersTest.Builders.BaseHandlers;

public class RoleHandlerTest : HandlerTest
{
    private Mock<IRoleRepository> repository = null!;

    public RoleHandlerTest()
    {
        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IRoleRepository>();

        repository.Setup(x => x.Get(RoleTest.ValidSomeIdObject())).
            Returns(Task.FromResult(RoleTest.ValidSomeObject()));

        repository.Setup(x => x.Get(RoleTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(RoleTest.ValidObjectOne()));
    }

    public RoleHandler GetHandler() =>
        new RoleHandler(repository.Object);

}