using Moq;
using Registration.Handlers.Handlers.Abstraction;

namespace Registration.UnitTest.Test.Builders.Models;
public class PostBuilders : BaseBuilder
{
    public Mock<IPostHandler> GetHandlerMock()
    {
        Mock<IPostHandler> mockPostHandler = new();

        mockPostHandler.Setup(x => x.GetByIds(It.IsAny<int[]>()))
            .Returns(Task.FromResult(true));

        return mockPostHandler;
    }
}
