using Microsoft.Extensions.Configuration;
using System.Security.Principal;

namespace MessageBroker;

public abstract class BaseMessageBrokerClient
{ 
    protected readonly IConfiguration _configuration;
   
    public bool AutoDelete = false;
    public bool Durable = false;
    public bool Exclusive = false;
    public bool AutomaticRecovery = false;

    protected BaseMessageBrokerClient(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string Exchange { get; protected set; } = string.Empty;
    public string Host { get; protected set; } = string.Empty;
    public string VirtualHost { get; protected set; } = string.Empty;
    public string Port { get; protected set; } = string.Empty;
    public string UserName { get; protected set; } = string.Empty;
    public string Password { get; protected set; } = string.Empty;
    public string Queue { get; protected set; } = string.Empty;
    public string RoutingKey { get; protected set; } = string.Empty;
    public byte[] BodyMessage { get; protected set; } = new byte[0];

    protected abstract byte[] BuildMessage();

    public string CreateUrl()
    {
        return "";
    }
}
