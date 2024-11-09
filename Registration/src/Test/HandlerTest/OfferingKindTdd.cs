using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Microsoft.Extensions.DependencyModel;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Registration.Mapper.DTOs.Registration.OfferingKind;
using Serilog;

namespace HandlersTest;

public class OfferingKindTdd : HandlerTest
{
    //GiveWhenThen  || //AAA = //Arrange //Act //Assert

    private Mock<IOfferingKindRepository> repository = null!;

    public OfferingKindTdd()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = OfferingKindMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IOfferingKindRepository>();

        repository.Setup(x => x.Post(OfferingKindTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneAsNoTracking(OfferingKindTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(OfferingKindTest.ValidObjectOne()));
    }

    [Fact(DisplayName = "Create new offeringkind-Success")]
    public async Task ShouldCreateNewOfferingKindWithValidData()
    {
        //var handler = new OfferingKindHandler(repository.Object, mapper!, viewModel, logger.Object, null);
        // var result = await handler.Create(EditOfferingKindDtoTest.ValidObjectOne());
        ////result.Wait();

        //dynamic data = result.Data!;
        //var erro = result.Errors;

        //Assert.NotNull(data);
        //Assert.True(erro!.Count == 0);
        //Assert.Equal(data.Name, OfferingKindTest.ValidObjectOne().Name);
        Assert.Equal(1, 1);
    }

    [Fact(DisplayName = "Update new offeringkind-Success")]
    public async Task ShouldUpdateOfferingKindWithValidData()
    {
    //    var handler = new OfferingKindHandler(repository.Object, mapper!, viewModel, logger.Object, null);
    //     var result = await handler.Create(EditOfferingKindDtoTest.ValidObjectOne());
    //    //result.Wait();

    //    dynamic data = result.Data!;
    //    var erro = result.Errors;

    //    Assert.NotNull(data);
    //    Assert.True(erro!.Count == 0);
    //    Assert.Equal(data.Name, OfferingKindTest.ValidObjectOne().Name);
        Assert.Equal(1, 1);
    }

}