using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest.Builders.BaseHandlers;

public class MemberPostHandlerTest : HandlerTest
{
    private Mock<IMemberPostRepository> repository = null!;

    public MemberPostHandlerTest()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = MemberPostMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IMemberPostRepository>();

        repository.Setup(x => x.Post(MemberPostTest.ValidObjectOne()));
    }

    public MemberPostHandler GetHandler() =>
        new MemberPostHandler(mapper!, viewModel, repository.Object, logger.Object);
}