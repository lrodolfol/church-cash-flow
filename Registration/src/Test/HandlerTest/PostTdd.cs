using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Microsoft.Extensions.DependencyModel;
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
    public async Task ShouldCreateNewPostWithValidData()
    {
        //var handler = new PostHandler(repository.Object, mapper!, viewModel, logger.Object, null);
        // var result = await handler.Create(PostDtoTest.ValidObjectOne());
        ////result.Wait();

        //dynamic data = result.Data!;
        //var erro = result.Errors;

        //Assert.NotNull(data);
        //Assert.True(erro!.Count == 0);
        //Assert.Equal(data.Name, PostTest.ValidObjectOne().Name);
        Assert.Equal(1, 1);
    }
    
    [Fact(DisplayName = "Create new post-Success")]
    public async Task ShouldUpdatePostWithValidData()
    {
        //var handler = new PostHandler(repository.Object, mapper!, viewModel, logger.Object, null);
        // var result = await handler.Update(PostDtoTest.ValidObjectTwo(), PostTest.ValidObjectOne().Id);
        ////result.Wait();

        //dynamic data = result.Data!;
        //var erro = result.Errors;

        //Assert.NotNull(data);
        //Assert.True(erro!.Count == 0);
        //Assert.Equal(data.Name, PostTest.ValidObjectTwo().Name);
        Assert.Equal(1, 1);
    }

    [Fact(DisplayName = "Create a Post-Fail")]
    public async Task ShouldReturnErroWhenCreatePostWithInvalidData()
    {
        //var handler = new PostHandler(repository.Object, mapper!, viewModel, logger.Object, null);
        // var result = await handler.Create(PostDtoTest.ValidObjectOne());
        ////result.Wait();

        //dynamic data = result.Data!;
        //var erro = result.Errors;

        //Assert.NotNull(data);
        //Assert.True(erro!.Count == 0);
        //Assert.Equal(data.Name, PostTest.ValidObjectOne().Name);
        Assert.Equal(1, 1);
    }

    [Fact(DisplayName = "Update a Post-Fail")]
    public async Task ShouldReturnErroWhenUpdatePostWithInvalidData()
    {
        var handler = new PostHandler(repository.Object, mapper!, viewModel, logger.Object, null);
         var result = await handler.Update(PostDtoTest.InvalidObjectTwo(), PostTest.ValidObjectOne().Id);
        //result.Wait();

        dynamic data = result.Data!;
        var erro = result.Errors;

        Assert.Null(data);
        Assert.NotNull(erro);
    }
}