using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using System.Runtime.CompilerServices;

namespace MessageBroker;

public class BlockMonthWorkMessage : BaseMessageBrokerClient
{
    public BlockMonthWorkMessage(IConfiguration configuration) : base(configuration)
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        Exchange = _configuration["MonthWorkMessageBroker:Exchange"]!;
        Host = _configuration["MonthWorkMessageBroker:Host"]!;
        VirtualHost = _configuration["MonthWorkMessageBroker:VirtualHost"]!;
        Port = _configuration["MonthWorkMessageBroker:Port"]!;
        UserName = _configuration["MonthWorkMessageBroker:UserName"]!;
        Password = _configuration["MonthWorkMessageBroker:Password"]!;
    }
}