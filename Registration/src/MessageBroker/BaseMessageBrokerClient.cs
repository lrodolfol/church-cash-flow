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

    public string Exchange { get; set; }
    public string Host { get; set; }
    public string VirtualHost { get; set; }
    public string Port { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Queue { get; set; }


    public string GeneratedMessage()
    {
        return "";
    }

    public string CreateUrl()
    {
        return "";
    }
}
