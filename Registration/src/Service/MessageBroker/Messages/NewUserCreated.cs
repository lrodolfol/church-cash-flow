using Microsoft.Extensions.Configuration;
using Registration.DomainCore.Events;
using System.Text.Json;
using System.Text;

namespace MessageBroker.Messages;
public class NewUserCreated : BaseMessageBrokerClient
{
    private readonly UserCreatedEvent _userCreated;

    public NewUserCreated(IConfiguration configuration, UserCreatedEvent userCreated) : base(configuration)
    {
        _userCreated = userCreated;
        LoadConfig();
    }

    public void PreparePublish()
    {
        IMessageBrokerClient rabbitClient = new RabbitMqClient<NewUserCreated>(this);

        rabbitClient.Publish();
    }

    protected override byte[] BuildMessage()
    {
        var objBody = new
        {
            _userCreated.Id,
            _userCreated.EmailAddress,
            _userCreated.OcurredOn
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
        RoutingKey = _configuration["MessageBroker:UserCreated:RoutingKey"]!;
        Queue = _configuration["MessageBroker:UserCreated:Queue"]!;

        BodyMessage = BuildMessage();
    }
}
