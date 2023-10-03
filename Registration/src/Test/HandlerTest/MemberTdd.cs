using HandlersTest.Builders.BaseHandlers;
using HandlersTest.Builders.Configs;
using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest;

public class MemberTdd : HandlerTest
{
    //GiveWhenThen  || //AAA = //Arrange //Act //Assert

    private Mock<IMemberRepository> repository = null!;

    public MemberTdd()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = MemberMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IMemberRepository>();

        repository.Setup(x => x.Post(MemberTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneNoTracking(It.IsAny<int>()))
            .Returns(Task.FromResult(MemberTest.ValidObjectOne()));

        repository.Setup(x => x.Put(MemberTest.ValidObjectTwo()));
        repository.Setup(x => x.GetOne(MemberTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(MemberTest.ValidObjectTwo()));
    }


    [Fact(DisplayName = "Create new member-Success")]
    public async Task ShouldCreateNewMemberWithValidData()
    {
        var memberBridgeHandler = new MemberBridgeHandlerTest().GetHandler();
        var postHandler = new PostHandlerTest().GetHandler();
        var churchHandler = new ChurchHandlerTest().GetHandler();
        var operationHandler = new OperationsHandlerTest().GetHandler();
        var config = new ConfigurationTest().getConfig;

        var handler = new MemberHandler(repository.Object, mapper!, viewModel, operationHandler, 
            postHandler, churchHandler, memberBridgeHandler, logger.Object, config.Object);

         var result = await handler.Create(EditMemberDtoTest.ValidObjectOne());
        //result.Wait();

        dynamic data = result.Data!;
        var erro = result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Name, PostTest.ValidObjectOne().Name);
    }
}