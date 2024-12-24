using Moq;
using Registration.Handlers.ViewModel;
using Serilog;

namespace Registration.UnitTest.Test;
public abstract class BaseUnitTest
{
    protected Mock<ILogger> _mockLogger { get; set; } = new Mock<ILogger>();
    protected ResultViewModel _viewModel { get; set; } = new ResultViewModel();
}
