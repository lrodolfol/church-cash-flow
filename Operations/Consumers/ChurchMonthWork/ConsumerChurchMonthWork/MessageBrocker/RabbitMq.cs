using ConsumerChurchMonthWork.Entitie;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Serilog;
using System.ComponentModel;
using System.Text;
using System.Text.Json;

namespace ConsumerChurchMonthWork.MessageBrocker;

internal class RabbitMq : BackgroundWorker, IMessageBrocker
{
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;
    private ConnectionFactory _connectionFactory = null!;

    public RabbitMq(IConfiguration configuration, ILogger logger)
    {
        _configuration = configuration;
        _logger = logger;

        LoadConfig();
    }
    public string Exchange { get; private set; } = null!;
    public string Host { get; private set; } = null!;
    public string VirtualHost { get; private set; } = null!;
    public string Port { get; private set; } = null!;
    public string UserName { get; private set; } = null!;
    public string Password { get; private set; } = null!;
    public string RoutingKey { get; private set; } = null!;
    public string Queue { get; private set; } = null!;


    private void LoadConfig()
    {
        Exchange = _configuration["MonthlyClosing:Exchange"]!;
        Host = _configuration["MonthlyClosing:Host"]!;
        VirtualHost = _configuration["MonthlyClosing:VirtualHost"]!;
        Port = _configuration["MonthlyClosing:Port"]!;
        UserName = _configuration["MonthlyClosing:UserName"]!;
        Password = _configuration["MonthlyClosing:Password"]!;
        RoutingKey = _configuration["MonthlyClosing:RoutingKey"]!;
        Queue = _configuration["MonthlyClosing:Queue"]!;
    }

    private ConnectionFactory CreateConnectionFromParameters()
    {
        if (SomeValueIsEmptyOrNull())
            throw new ArgumentNullException("Check the messageBroker properties");

        _connectionFactory = new ConnectionFactory()
        {
            HostName = Host,
            UserName = UserName,
            Password = Password,
            Port = int.Parse(Port!.Trim())
        };

        return _connectionFactory;
    }

    private bool SomeValueIsEmptyOrNull() => (string.IsNullOrEmpty(Host) |
        string.IsNullOrEmpty(UserName) |
        string.IsNullOrEmpty(Password) |
        string.IsNullOrEmpty(Port));



    public void StartConsumer()
    {
        CreateConnectionFromParameters();


        _logger.Information("Consumindo monthly closing");

        using var connection = _connectionFactory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.ExchangeDeclare(exchange: Exchange, type: ExchangeType.Topic);
        channel.QueueDeclare(queue: Queue,
                             durable: false,
                             exclusive: false,
                             autoDelete: false,
                             arguments: null);

        channel.QueueBind(queue: Queue,
                              exchange: Exchange,
                              routingKey: RoutingKey);

        var consumer = new EventingBasicConsumer(channel);

        consumer.Received += (model, ea) =>
        {
            ReadMessage(ea);
        };

        channel.BasicConsume(queue: Queue,
                             autoAck: true,
                             consumer: consumer);

        while (true)
        {
            var result = channel.BasicGet(Queue, autoAck: true);
        }
    }

    private static void ReadMessage(BasicDeliverEventArgs ea)
    {
        var body = ea.Body.ToArray();
        if (body.Length == 0)
            return;

        var message = Encoding.UTF8.GetString(body);

        var objBody = JsonSerializer.Deserialize<ObjMessage>(message);

        Console.WriteLine($"Received message: {objBody!.ChurcId}, {objBody.YearMonth}");
    }
}
