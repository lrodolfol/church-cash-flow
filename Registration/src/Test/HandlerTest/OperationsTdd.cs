using HandlersTest.Builders.BaseHandlers;
using HandlersTest.Builders.Configs;
using HandlersTest.Builders.Dtos;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainBase.Entities.Operations;
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
    public void ShouldBlockMonthWithValidData()
    {
        var config = new ConfigurationTest().getConfig;

        var handler = new OperationsHandler(mapper!, viewModel, repository.Object, config.Object, logger.Object);
        var result = handler.BlockMonthWork(EditMonthWorkDtoTest.ValidObjectOneBlock());
        result.Wait();

        Assert.Null(result.Result.Errors);
        Assert.Null(result.Result.Data);
    }

    [Fact(DisplayName = "Unblock month-Success")]
    public void ShouldUnblockMonthWithValidData()
    {
        var config = new ConfigurationTest().getConfig;

        var handler = new OperationsHandler(mapper!, viewModel, repository.Object, config.Object, logger.Object);
        var result = handler.UnblockMonthWork(EditMonthWorkDtoTest.ValidObjectOneUnblock().Id);
        result.Wait();

        Assert.Null(result.Result.Errors);
        Assert.Null(result.Result.Data);
    }    
    
    [Fact(DisplayName = "Run record MonthWork-Success")]
    public void ShouldGenerateReportMonthlykWithValidData()
    {
        var report = new Report(repositoryReport.Object, ChurchTest.ValidObjectOne().Id, MonthlyClosingTest.ValidObjectOneInput().Competence!);
        var resultReport = report.Generate();
        resultReport.Wait();
        var listResult = resultReport.Result;

        var monthlyObjectes = MonthlyClosingTest.GetValidObjectes();

        var reportForget = new ReportForge(monthlyObjectes);
        var objList = reportForget.GenerateObjectRecord(listResult!);

        var totalList = SumValues(objList);
        var totalListObjects = SumValues(monthlyObjectes);

        Assert.Equal(totalList, totalListObjects);
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