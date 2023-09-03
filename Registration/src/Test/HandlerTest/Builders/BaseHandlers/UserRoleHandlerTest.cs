using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest.Builders.BaseHandlers;

public class UserRoleHandlerTest : HandlerTest
{
    private Mock<IUserRoleRepository> repository = null!;

    public UserRoleHandlerTest()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = UserRoleMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IUserRoleRepository>();
        repository.Setup(x => x.Post(UserRoleTest.ValidObjectOne()));
    }

    public UserRoleHandler GetHandler()
    {
        var handler = new UserRoleHandler(repository.Object, mapper!, viewModel, logger.Object);

        //handler.Setup(x => x.Create(UserTest.ValidObjectOne().Id, RoleTest.ValidSomeIdObject()));
        //handler.Setup(x => x.Get(RoleTest.ValidSomeIdObject()))
        //    .Returns(Task.FromResult(RoleTest.ValidSomeIdObject().Length > 0));

        return handler;
    }
}
