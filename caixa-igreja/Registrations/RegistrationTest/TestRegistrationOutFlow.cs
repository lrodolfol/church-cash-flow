using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Data.ViewModels.Dtos.OutFlow;
using ChurchCashFlow.Handlers;
using ChurchCashFlow.Profiles;
using DataModelChurchCashFlow.Context.Interface;
using RegistrationTest.ContextFake;

namespace RegistrationTest;
public class TestRegistrationOutFlow
{
    private readonly OutFlowHanler _handler;
    private readonly IOutFlowContext _context = new OutFlowContextFake();
    private IMapper _mapper;
    public TestRegistrationOutFlow()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new OutFlowProfile());
        });

        _mapper = confMapper.CreateMapper();

        _handler = new OutFlowHanler(_context, _mapper);
    }

    [Fact]
    [Trait("Xunit", "Add new OutFlow")]
    public void ShouldAddNewOutFlowNormaly()
    {
        var editOutFlowDto = new EditOutFlowDto
        {
            Id = OutFlowContextFake.OutFlows.Count() + 1,
            Amount = 100,
            Day = DateTime.Parse("2023-03-01"),
            Discount = 0,
            Interest = 0,
            MonthYear = DateTime.Now.ToString("MM/yyyy"),
            OutFlowKindId = 1
        };

        var resultViewModel = _handler.Create(editOutFlowDto);

        Assert.NotNull(resultViewModel.Result.Data);
    }

    [Theory]
    [InlineData(120.89, 100, 21, 0.11)]
    [InlineData(0.69, 1.30, 0, 0.61)]
    [InlineData(1.23, 0.21, 1.05, 0.03)]
    [InlineData(1540.55, 1521, 19.55, 0)]
    [Trait("Xunit", "Test the totalAmount")]
    public void TotalAmountShoudBeCorretct(decimal received, decimal amount, decimal interest, decimal discount)
    {
        //decimal[] amounts = new decimal[] { 100m, 1.30m, 0.21m, 1521m };
        //decimal[] interests = new decimal[] { 21m, 0m, 1.05m, 19.55m };
        //decimal[] discounts = new decimal[] { 0.11m, 0.61m, 0.03m, 0m };

        var editOutFlowDto = new EditOutFlowDto
        {
            Id = OutFlowContextFake.OutFlows.Count() + 1,
            Amount = amount,
            Day = DateTime.Parse("2023-03-01"),
            Discount = discount,
            Interest = interest,
            MonthYear = DateTime.Now.ToString("MM/yyyy"),
            OutFlowKindId = 1
        };

        var resultViewModel = _handler.Create(editOutFlowDto);
        decimal valueResult = resultViewModel.Result.Data.TotalAmount;

        Assert.Equal(received, valueResult);
    }
}
