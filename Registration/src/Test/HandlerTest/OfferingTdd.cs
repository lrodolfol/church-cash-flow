using AutoMapper;
using HandlersTest.Builders.BaseHandlers;
using HandlersTest.Builders.Dto;
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

public class OfferingTdd : HandlerTest
{
    //GiveWhenThen  || //AAA = //Arrange //Act //Assert

    private Mock<IOfferingRepository> repository = null!;

    public OfferingTdd()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = OfferingMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IOfferingRepository>();
        repository.Setup(x => x.Post(OfferingTest.ValidObjectOne()));

        repository.Setup(x => x.Put(OfferingTest.ValidObjectTwo()));
        repository.Setup(x => x.GetOne(OfferingTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(OfferingTest.ValidObjectOne()));

        repository.Setup(x => x.GetOne(OfferingTest.ValidObjectTwo().Id))
            .Returns(Task.FromResult(OfferingTest.ValidObjectTwo()));

        repository.Setup(x => x.GetOneAsNoTracking(OfferingTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(OfferingTest.ValidObjectOne()));

        repository.Setup(x => x.GetOneAsNoTracking(OfferingTest.ValidObjectTwo().Id))
            .Returns(Task.FromResult(OfferingTest.ValidObjectTwo()));
    }

    [Fact(DisplayName = "Create new offering-Success")]
    public void ShouldCreateNewOfferingWithValidData()
    {
        var operHandler = new OperationsHandlerTest().GetHandler();

        var handler = new OfferingHandler(repository.Object, mapper!, viewModel, operHandler, logger.Object);
        var result = handler.CreateAsync(EditOfferingDtoTest.ValidObjectOne());
        result.Wait();

        dynamic data = result.Result.Data!;
        var erro = result.Result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Description, OfferingTest.ValidObjectOne().Description);
    }

    [Fact(DisplayName = "Update offering-Success")]
    public void ShouldUpdateOfferingWithValidData()
    {
        var operHandler = new OperationsHandlerTest().GetHandler();

        var handler = new OfferingHandler(repository.Object, mapper!, viewModel, operHandler, logger.Object);
        var result = handler.UpdateAsync(EditOfferingDtoTest.ValidObjectTwo(), OfferingTest.ValidObjectOne().Id);
        result.Wait();

        dynamic data = result.Result.Data!;
        var erro = result.Result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Description, OfferingTest.ValidObjectTwo().Description);
    }

}