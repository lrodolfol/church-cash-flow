using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest.Builders.BaseHandlers;

public class ChurchHandlerTest : HandlerTest
{
    private Mock<IChurchRepository> repository = null!;
    public ChurchHandlerTest()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = ChurchMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IChurchRepository>();
        repository.Setup(x => x.Post(ChurchTest.ValidObjectOne()));
        repository.Setup(x => x.GetOneNoTracking(It.IsAny<int>()))
            .Returns(Task.FromResult(ChurchTest.ValidObjectOne()));

        repository.Setup(x => x.Put(ChurchTest.ValidObjectTwo()));
        repository.Setup(x => x.GetOne(ChurchTest.ValidObjectOne().Id))
            .Returns(Task.FromResult(ChurchTest.ValidObjectOne()));
    }

    public ChurchHandler GetHandler() =>
        new ChurchHandler(repository.Object, mapper!, viewModel, logger.Object);
}