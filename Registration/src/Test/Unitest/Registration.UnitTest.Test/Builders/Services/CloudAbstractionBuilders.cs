using Moq;
using Registration.DomainCore.CloudAbstration;

namespace Registration.UnitTest.Test.Builders.Services;
public class CloudAbstractionBuilders
{
    public Mock<IImageStorage> GetImageStoreMock()
    {
        Mock<IImageStorage> mock = new Mock<IImageStorage>();

        mock.Setup(x => x.SaveImage())
            .Returns(Task.FromResult(true));

        return mock;
    }
}
