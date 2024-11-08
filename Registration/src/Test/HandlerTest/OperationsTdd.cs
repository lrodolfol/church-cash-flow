using HandlersTest.Builders.BaseHandlers;
using HandlersTest.Builders.Configs;
using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using HandlersTest.Builders.Repository;
using Moq;
using Registration.DomainBase.Entities.Operations;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.InterfaceRepository;
using Registration.Handlers;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Registration.Mapper.DTOs.Registration.MonthWork;
using Serilog;

namespace HandlersTest;

public class OperationsTdd : HandlerTest
{
    //GiveWhenThen  || //AAA = //Arrange //Act //Assert

    private Mock<IMonthWorkRepository> repository = null!;
    private Mock<IMonthlyClosingDataBase> repositoryReport = null!;

    public OperationsTdd()
    {
        viewModel = new ResultViewModel();
        logger = new Mock<ILogger>();
        mapper = OperationMapperTest.Mapper();

        GetAbstractionContext();
    }

    private void GetAbstractionContext()
    {
        repository = new Mock<IMonthWorkRepository>();
        repository.Setup(x => x.GetOne(MonthWorkTest.ValidObjectOneBlock()!.Id))
            .Returns(Task.FromResult(MonthWorkTest.ValidObjectOneBlock()));
        repository.Setup(x => x.GetOne(MonthWorkTest.ValidObjectOneUnblock()!.Id))
            .Returns(Task.FromResult(MonthWorkTest.ValidObjectOneUnblock()));

        repositoryReport = new Mock<IMonthlyClosingDataBase>();
        repositoryReport.Setup(x => x.SelectReportAsync(It.IsAny<string>(), 
            "09", 
            "2023"))
            .Returns(Task.FromResult(MonthlyClosingTest.GetValidObjectes()));
    }

    [Fact(DisplayName = "Block month-Success")]
    public async Task ShouldBlockMonthWithValidData()
    {
        var month = EditMonthWorkDtoTest.ValidObjectOneBlock();
        var config = new ConfigurationTest().getConfig;
        var monthlyClosing = new MysqlMonthlyClosingRepositoryTest(config.Object);

        var handler = new OperationsHandler(mapper!, viewModel, repository.Object, config.Object, logger.Object, monthlyClosing, null);
        var result = await handler.BlockMonthWork(EditMonthWorkDtoTest.ValidObjectOneBlock());
        repository.Verify(x =>
            x.Create(It.IsAny<MonthWork>()), Times.Once
        );

        Assert.True(result.Errors!.Count == 0);
        Assert.NotNull(result.Data);
    }

    [Fact(DisplayName = "Unblock month-Success")]
    public async Task ShouldUnblockMonthWithValidData()
    {
        var config = new ConfigurationTest().getConfig;
        var monthlyClosing = new MysqlMonthlyClosingRepositoryTest(config.Object);
        
        var handler = new OperationsHandler(mapper!, viewModel, repository.Object, config.Object, logger.Object, monthlyClosing, null);
         var result = await handler.UnblockMonthWork(EditMonthWorkDtoTest.ValidObjectOneUnblock().Id);
        //result.Wait();

        Assert.True(result.Errors!.Count == 0);
        Assert.Null(result.Data);
    }    
    
    private decimal SumValues(List<MonthlyClosing> list)
    {
        var value = 0m;
        list.ForEach(x =>
        {
            value += x.AmountInputOperation;
            value -= x.AmountOutPutOperation;
        });

        return value;
    }
}