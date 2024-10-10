using Microsoft.Extensions.Configuration;
using Moq;

namespace HandlersTest.Builders.Configs;

public class ConfigurationTest
{
    public Mock<IConfiguration> getConfig => GetConfig();

    private Mock<IConfiguration> GetConfig()
    {
        // Mock da seção para a string de conexão "DefaultConnectionMySQL"
        //var mockConfiguration = new Mock<IConfigurationSection>();

        var mockConfSection = new Mock<IConfigurationSection>();
        mockConfSection.SetupGet(m => m[It.Is<string>(s => s == "DefaultConnectionMySQL")]).Returns("server=localhost;port=3310;database=ChurchCashFlow;user=root;password=sinqia123");

        var config = new Mock<IConfiguration>();
        config.Setup(a => a.GetSection(It.Is<string>(s => s == "ConnectionStrings")))
            .Returns(mockConfSection.Object);

        //rabbitmq
        config.Setup(x => x.GetSection("MessageBroker:Host").Value)
            .Returns("localhost");
        config.Setup(x => x.GetSection("MessageBroker:VirtualHost").Value)
            .Returns("");
        config.Setup(x => x.GetSection("MessageBroker:Port").Value)
            .Returns("5672");
        config.Setup(x => x.GetSection("MessageBroker:UserName").Value)
            .Returns("sinqia");
        config.Setup(x => x.GetSection("MessageBroker:Password").Value)
            .Returns("sinqia123");
        //
        config.Setup(x => x.GetSection("MessageBroker:UserCreated:Exchange").Value)
            .Returns("user");
        config.Setup(x => x.GetSection("MessageBroker:UserCreated:RoutingKey").Value)
            .Returns("created");
        config.Setup(x => x.GetSection("MessageBroker:UserCreated:Queue").Value)
            .Returns("user_created");
        //
        config.Setup(x => x.GetSection("MessageBroker:MonthWorkMessageBroker:Exchange").Value)
            .Returns("church_month_work");
        config.Setup(x => x.GetSection("MessageBroker:MonthWorkMessageBroker:RoutingKey").Value)
            .Returns("month_work");
        config.Setup(x => x.GetSection("MessageBroker:MonthWorkMessageBroker:Queue").Value)
            .Returns("church_month_work");

        //mysql
        config.Setup(x => x.GetSection("DefaultConnectionMySQL").Value)
            .Returns("server=localhost;port=3310;database=ChurchCashFlow;user=root;password=sinqia123");

        return config;
    }
}
