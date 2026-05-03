using Microsoft.Extensions.Configuration;

namespace MessageBroker.RabbitMq;

public abstract class RabbitMqBaseEvent : BaseMessageBrockerEvent
{
    protected readonly IConfiguration _configuration;

    public bool AutoDelete = false;
    public bool Durable = false;
    public bool Exclusive = false;
    public bool AutomaticRecovery = false;

    protected RabbitMqBaseEvent(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string Exchange { get; protected set; } = string.Empty;
    public string ExchangeDeadLeatter { get; protected set; } = string.Empty;
    public string Host { get; protected set; } = string.Empty;
    public string VirtualHost { get; protected set; } = string.Empty;
    public string Port { get; protected set; } = string.Empty;
    public string UserName { get; protected set; } = string.Empty;
    public string Password { get; protected set; } = string.Empty;
    public string Queue { get; protected set; } = string.Empty;
    public string QueueDeadLeatter { get; protected set; } = string.Empty;
    public string RoutingKey { get; protected set; } = string.Empty;
    public string RoutingKeyDeadLeatter { get; protected set; } = string.Empty;
    public byte[] BodyMessage { get; protected set; } = new byte[0];

    protected abstract byte[] BuildMessage();
    protected abstract void LoadConfig();

    public string[] ValidateRequiredProperties()
    {
        var emptyProperties = new List<string>();

        if (string.IsNullOrWhiteSpace(Host))
            emptyProperties.Add(nameof(Host));

        if (string.IsNullOrWhiteSpace(Port))
            emptyProperties.Add(nameof(Port));

        if (string.IsNullOrWhiteSpace(UserName))
            emptyProperties.Add(nameof(UserName));

        if (string.IsNullOrWhiteSpace(Password))
            emptyProperties.Add(nameof(Password));

        if (string.IsNullOrWhiteSpace(Queue))
            emptyProperties.Add(nameof(Queue));

        if (string.IsNullOrWhiteSpace(Exchange))
            emptyProperties.Add(nameof(Exchange));

        if (string.IsNullOrWhiteSpace(RoutingKey))
            emptyProperties.Add(nameof(RoutingKey));

        if (BodyMessage == null || BodyMessage.Length == 0)
            emptyProperties.Add(nameof(BodyMessage));

        return emptyProperties.ToArray();
    }

    public string CreateUrl()
    {
        return "";
    }
}
