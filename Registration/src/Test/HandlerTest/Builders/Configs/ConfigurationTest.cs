using Microsoft.Extensions.Configuration;
using Moq;

namespace HandlersTest.Builders.Configs;

public class ConfigurationTest
{
    public Mock<IConfiguration> getConfig => GetConfig();

    private Mock<IConfiguration> GetConfig()
    {
        Mock<IConfiguration> config =new Mock<IConfiguration>();

        var connString = "server=localhost;port=3306;database=ChurchCashFlow;user=root;password=sinqia123";

        //mysql
        config.Setup(x => x.GetSection("DefaultConnectionMySQL").Value)
            .Returns(connString);

        //rabbitmq
        config.Setup(x => x.GetSection("MonthWorkMessageBroker:Exchange").Value)
            .Returns(connString);
        config.Setup(x => x.GetSection("MonthWorkMessageBroker:Host").Value)
            .Returns(connString);
        config.Setup(x => x.GetSection("MonthWorkMessageBroker:VirtualHost").Value)
            .Returns(connString);
        config.Setup(x => x.GetSection("MonthWorkMessageBroker:Port").Value)
            .Returns(connString);
        config.Setup(x => x.GetSection("MonthWorkMessageBroker:UserName").Value)
            .Returns(connString);
        config.Setup(x => x.GetSection("MonthWorkMessageBroker:Password").Value)
            .Returns(connString);
        config.Setup(x => x.GetSection("MonthWorkMessageBroker:RoutingKey").Value)
            .Returns(connString);
        config.Setup(x => x.GetSection("MonthWorkMessageBroker:Queue").Value)
            .Returns(connString);

        return config;
    }
}
