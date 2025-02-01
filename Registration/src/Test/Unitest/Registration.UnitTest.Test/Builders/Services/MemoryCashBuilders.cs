using Microsoft.Extensions.Caching.Memory;
using Moq;

namespace Registration.UnitTest.Test.Builders.Services;
public class MemoryCashBuilders
{
    public Mock<IMemoryCache> GetMock()
    {
        Mock<IMemoryCache> mock = new Mock<IMemoryCache>();

        return mock;
    }
}
