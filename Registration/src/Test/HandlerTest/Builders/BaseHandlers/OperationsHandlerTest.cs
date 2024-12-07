using HandlersTest.Builders.Configs;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using HandlersTest.Builders.Repository;
using Microsoft.Extensions.Configuration;
using Moq;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest.Builders.BaseHandlers;

public class OperationsHandlerTest : HandlerTest
{
    private Mock<IMonthWorkRepository> repository = null!;
    public OperationsHandlerTest()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = ChurchMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IMonthWorkRepository>();
    }

    public OperationsHandler GetHandler()
    {
        var config = new ConfigurationTest();
        Mock<IConfiguration> configMock = config.getConfig;
        var monthlyClosing = new MysqlMonthlyClosingRepositoryTest(configMock.Object);

        return new OperationsHandler(mapper!, viewModel, repository.Object, configMock.Object, logger.Object, null);
    }        
}