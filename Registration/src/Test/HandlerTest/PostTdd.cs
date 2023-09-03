using AutoMapper;
using HandlersTest.Builders.Dto;
using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest;

public class PostTdd : HandlerTest
{
    //GiveWhenThen  || //AAA = //Arrange //Act //Assert

    private Mock<IPostRepository> repository = null!;

    public PostTdd()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = PostMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IPostRepository>();
        repository.Setup(x => x.Post(PostTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneNoTracking(It.IsAny<int>()))
            .Returns(Task.FromResult(PostTest.ValidObjectOne()));

        repository.Setup(x => x.Put(PostTest.ValidObjectTwo()));
        repository.Setup(x => x.GetOne(PostTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(PostTest.ValidObjectTwo()));
    }

    [Fact(DisplayName = "Create new post-Success")]
    public void ShouldCreateNewChurchWithValidData()
    {
        var handler = new PostHandler(repository.Object, mapper!, viewModel, logger.Object);
        var result = handler.Create(PostDtoTest.ValidObjectOne());
        result.Wait();

        dynamic data = result.Result.Data!;
        var erro = result.Result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Name, PostTest.ValidObjectOne().Name);
    }
    
    [Fact(DisplayName = "Create new post-Success")]
    public void ShouldUpdateChurchWithValidData()
    {
        var handler = new PostHandler(repository.Object, mapper!, viewModel, logger.Object);
        var result = handler.Update(PostDtoTest.ValidObjectTwo(), PostTest.ValidObjectOne().Id);
        result.Wait();

        dynamic data = result.Result.Data!;
        var erro = result.Result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Name, PostTest.ValidObjectTwo().Name);
    }

    [Fact(DisplayName = "Create a Post-Fail")]
    public void ShouldReturnErroWhenCreateChurchWithInvalidData()
    {
        var handler = new PostHandler(repository.Object, mapper!, viewModel, logger.Object);
        var result = handler.Create(PostDtoTest.ValidObjectOne());
        result.Wait();

        dynamic data = result.Result.Data!;
        var erro = result.Result.Errors;

        Assert.NotNull(data);
        Assert.True(erro!.Count == 0);
        Assert.Equal(data.Name, PostTest.ValidObjectOne().Name);
    }

    [Fact(DisplayName = "Update a Post-Fail")]
    public void ShouldReturnErroWhenUpdateChurchWithInvalidData()
    {
        var handler = new PostHandler(repository.Object, mapper!, viewModel, logger.Object);
        var result = handler.Update(PostDtoTest.InvalidObjectTwo(), PostTest.ValidObjectOne().Id);
        result.Wait();

        dynamic data = result.Result.Data!;
        var erro = result.Result.Errors;

        Assert.Null(data);
        Assert.NotNull(erro);
    }
}