using HandlersTest.Builders.BaseHandlers;
using HandlersTest.Builders.Configs;
using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Events.NewCreatedUserEvent;
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
        repository.Setup(x => x.GetOneNoTracking(It.IsAny<int>()))
            .Returns(Task.FromResult(UserTest.ValidObjectOne()));

        repository.Setup(x => x.GetOne(UserTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(UserTest.ValidObjectOne()));
    }

    [Fact(DisplayName = "Create new User-Success")]
    public async Task ShouldCreateNewUserWithValidData()
    {
        Environment.SetEnvironmentVariable("KEYUSERCREATED", "AAECAwQFBgcICQoLDA0ODw==");
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");

        var userRoleHandlerTest = new UserRoleHandlerTest();
        var userRoleHand = userRoleHandlerTest.GetHandler();

        var roleHandlerTest = new RoleHandlerTest();
        var roleHand = roleHandlerTest.GetHandler();
        var config = new ConfigurationTest().getConfig;
        var domainBase = new NewUserCreatedTest(config.Object);

        var handler = new UserHandler(repository.Object, mapper!, viewModel, userRoleHand, roleHand, logger.Object, domainBase);
         var result = await handler.Create(EditUserCreateDtoTest.ValidObjectOne());
        //result.Wait();

        dynamic data = result.Data!;
        var erro = result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Name, UserTest.ValidObjectOne().Name);
    }

    [Fact(DisplayName = "Update new User-Success")]
    public async Task ShouldUpdateUserWithValidData()
    {
        var userRoleHandlerTest = new UserRoleHandlerTest();
        var userRoleHand = userRoleHandlerTest.GetHandler();

        var roleHandlerTest = new RoleHandlerTest();
        var roleHand = roleHandlerTest.GetHandler();
        var config = new ConfigurationTest().getConfig;
        var domainBase = new NewUserCreatedTest(config.Object);

        var userCreatedTest = new NewUserCreatedTest(new ConfigurationTest().getConfig.Object);

        var handler = new UserHandler(repository.Object, mapper!, viewModel, userRoleHand, roleHand, logger.Object, domainBase);
         var result = await handler.Update(EditUserDtoTest.ValidObjectTwo(), EditUserDtoTest.ValidObjectOne().Id);
        //result.Wait();

        dynamic data = result.Data!;
        var erro = result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Name, UserTest.ValidObjectTwo().Name);
    }
}