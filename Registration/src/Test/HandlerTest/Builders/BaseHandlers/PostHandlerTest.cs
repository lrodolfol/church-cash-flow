using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest.Builders.BaseHandlers;

public class PostHandlerTest : HandlerTest
{
    private Mock<IPostRepository> repository = null!;
    public PostHandlerTest()
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

        repository.Setup(x => x.GetByIds(It.IsAny<int[]>()))
            .Returns(PostTest.GetQueryableValidObjects());
    }

    public PostHandler GetHandler()
    {
        var mockHand = new PostHandler(repository.Object, mapper!, viewModel, logger.Object);

        return mockHand;
    }
        
}