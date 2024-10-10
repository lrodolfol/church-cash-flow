using Microsoft.Extensions.Configuration;
using Registration.DomainCore.Events;
using System.Text;
using System.Text.Json;

namespace MessageBroker.Messages;

public class BlockMonthWorkMessage : BaseMessageBrokerClient
{
    public BlockMonthWorkMessage(IConfiguration configuration) : base(configuration)
    {
        LoadConfig();
    }

    public int ChurchId { get; private set; }
    public string YearMonth { get; private set; }

    protected override void LoadConfig()
    {
        Exchange = _configuration["MonthWorkMessageBroker:Exchange"]!;
        Host = _configuration["MonthWorkMessageBroker:Host"]!;
        VirtualHost = _configuration["MonthWorkMessageBroker:VirtualHost"]!;
        Port = _configuration["MonthWorkMessageBroker:Port"]!;
        UserName = _configuration["MonthWorkMessageBroker:UserName"]!;
        Password = _configuration["MonthWorkMessageBroker:Password"]!;
        RoutingKey = _configuration["MonthWorkMessageBroker:RoutingKey"]!;
        Queue = _configuration["MonthWorkMessageBroker:Queue"]!;
        ExchangeDeadLeatter = $"{Exchange}_dead_leatter";
        RoutingKeyDeadLeatter = $"{RoutingKey}_dead_leatter";
        QueueDeadLeatter = $"{Queue}_dead_leatter";
    }

    public override void PreparePublish(DomainBaseEvents _domainEvent)
    {
        throw new NotImplementedException();
    }
    public void PreparePublish(monthlyClosedEvents monthlyClosed)
    {
        ChurchId = monthlyClosed._churchId;
        YearMonth = monthlyClosed._competence;

        BodyMessage = BuildMessage();

        IMessageBrokerClient rabbitClient = new RabbitMqClient<BlockMonthWorkMessage>(this);

        rabbitClient.Publish();
    }

    protected override byte[] BuildMessage()
    {
        var objBody = new
        {
            ChurchId,
            YearMonth
        };

        var serialize = JsonSerializer.Serialize(objBody);
        var body = Encoding.UTF8.GetBytes(serialize);

        return body;
    }
}