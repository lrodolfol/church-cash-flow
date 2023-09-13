using AutoMapper;
using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest;

public class OuflowKindTdd : HandlerTest
{
    //GiveWhenThen  || //AAA = //Arrange //Act //Assert

    private Mock<IOutFlowKindRepository> repository = null!;

    public OuflowKindTdd()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = OutFlowKindMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IOutFlowKindRepository>();
        repository.Setup(x => x.Post(OutFlowKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneAsNoTracking(OutFlowKindTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(OutFlowKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneAsNoTracking(OutFlowKindTest.ValidObjectTwo().Id))
            .Returns(Task.FromResult(OutFlowKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneAsNoTracking(OutFlowKindTest.ValidObjectThree().Id))
            .Returns(Task.FromResult(OutFlowKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneAsNoTracking(OutFlowKindTest.ValidObjectFour().Id))
            .Returns(Task.FromResult(OutFlowKindTest.ValidObjectOne()));

        repository.Setup(x => x.Post(OutFlowKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOne(OutFlowKindTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(OutFlowKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOne(OutFlowKindTest.ValidObjectTwo().Id))
            .Returns(Task.FromResult(OutFlowKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOne(OutFlowKindTest.ValidObjectThree().Id))
            .Returns(Task.FromResult(OutFlowKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOne(OutFlowKindTest.ValidObjectFour().Id))
            .Returns(Task.FromResult(OutFlowKindTest.ValidObjectOne()));
    }


    [Fact(DisplayName = "Create new outflowkind-Success")]
    public void ShouldCreateNewPostWithValidData()
    {
        var handler = new OutFlowKindHandler(repository.Object, mapper!, viewModel, logger.Object);
        var result = handler.Create(EditOutFlowKindDtoTest.ValidObjectOne());
        result.Wait();

        dynamic data = result.Result.Data!;
        var erro = result.Result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Name, EditOutFlowKindDtoTest.ValidObjectOne().Name);
    }

}
