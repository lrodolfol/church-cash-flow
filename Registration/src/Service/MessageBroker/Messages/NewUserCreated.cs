using Microsoft.Extensions.Configuration;
using Registration.DomainCore.Events;
using System.Text.Json;
using System.Text;

namespace MessageBroker.Messages;
public class NewUserCreated : BaseMessageBrokerClient
{
    private UserCreatedEvent _domainEnvent;
    public NewUserCreated(IConfiguration configuration) : base(configuration)
    {
        LoadConfig();
    }

    public override void PreparePublish(DomainBaseEvents userCreated)
    {
        _domainEnvent = (UserCreatedEvent)userCreated;
        BodyMessage = BuildMessage();

        IMessageBrokerClient rabbitClient = new RabbitMqClient<NewUserCreated>(this);

        rabbitClient.Publish();
    }

    protected override byte[] BuildMessage()
    {
        var objBody = new
        {
            _domainEnvent.Id,
            _domainEnvent.EmailAddress,
            _domainEnvent.OcurredOn,
            _domainEnvent.Password
        };

        var serialize = JsonSerializer.Serialize(objBody);
        var body = Encoding.UTF8.GetBytes(serialize);

        return body;
    }
    protected override void LoadConfig()
    {
        Host = _configuration["MessageBroker:Host"]!;
        VirtualHost = _configuration["MessageBroker:VirtualHost"]!;
        Port = _configuration["MessageBroker:Port"]!;
        UserName = _configuration["MessageBroker:UserName"]!;
        Password = _configuration["MessageBroker:Password"]!;
        Exchange = _configuration["MessageBroker:UserCreated:Exchange"]!;
        ExchangeDeadLeatter = $"{Exchange}_dead_leatter";
        RoutingKey = _configuration["MessageBroker:UserCreated:RoutingKey"]!;
        RoutingKeyDeadLeatter = $"{RoutingKey}_dead_leatter";
        Queue = _configuration["MessageBroker:UserCreated:Queue"]!;
        QueueDeadLeatter = $"{Queue}_dead_leatter";
    }
}
