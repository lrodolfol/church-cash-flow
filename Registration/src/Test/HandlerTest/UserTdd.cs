using HandlersTest.Builders.BaseHandlers;
using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest;

public class UserTdd : HandlerTest
{
    //GiveWhenThen  || //AAA = //Arrange //Act //Assert

    private Mock<IUserRepository> repository = null!;

    public UserTdd()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = UserMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IUserRepository>();

        repository.Setup(x => x.Post(UserTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneNoTracking(0))
            .Returns(Task.FromResult(UserTest.ValidObjectOne()));
    }

    [Fact(DisplayName = "Create new User-Success")]
    public void ShouldCreateNewUserWithValidData()
    {
        var userRoleHandlerTest = new UserRoleHandlerTest();
        var userRoleHand = userRoleHandlerTest.GetHandler();

        var roleHandlerTest = new RoleHandlerTest();
        var roleHand = roleHandlerTest.GetHandler();

        var handler = new UserHandler(repository.Object, mapper!, viewModel, userRoleHand, roleHand, logger.Object);
        handler.Create(EditUserCreateDtoTest.ValidObjectOne()).Wait();
    }
}