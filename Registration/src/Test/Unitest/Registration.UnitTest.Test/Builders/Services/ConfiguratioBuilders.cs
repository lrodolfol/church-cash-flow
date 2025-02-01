using Microsoft.Extensions.Configuration;
using Moq;
using Registration.UnitTest.Test.Builders.Models;

namespace Registration.UnitTest.Test.Builders.Services;
public class ConfiguratioBuilders : BaseBuilder
{
    public Mock<IConfigurationSection> GetConfiguration()
    {
        var mock = new Mock<IConfigurationSection>();

        return mock;
    }
}
