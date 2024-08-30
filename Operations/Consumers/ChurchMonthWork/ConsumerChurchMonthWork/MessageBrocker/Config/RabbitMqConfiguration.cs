namespace ConsumerChurchMonthWork.MessageBrocker.Config;
public class RabbitMQConfiguration
{
    public const string ConfigurationSection = "RabbitMQ";
    public string? Host { get; set; }
    public string? VirtualHost { get; set; }
    public int Port { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}

