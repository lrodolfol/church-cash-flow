using Moq;
using Registration.DomainBase.Entities.Registrations;
using Registration.Handlers.Handlers.Abstraction;

namespace Registration.UnitTest.Test.Builders.Models;
public class OperationsBuilder : BaseBuilder
{
    public Mock<IOperationsHandler> GetHandlerMock()
    {
        Mock<IOperationsHandler> mock = new Mock<IOperationsHandler>();
        mock.Setup(x => x.GetOneByCompetence(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(Task.FromResult(new MonthWork(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1)));

        return mock;
    }
}
