using Microsoft.Extensions.Hosting;
using Serilog;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using ConsumerChurchMonthWork.Models;
using System.Text.Json;
using System.Text;

namespace ConsumerChurchMonthWork.MessageBrocker.Consumer;
public class MonthWorkListener : BackgroundService
{
    private readonly IModel _channel;
    private readonly ILogger _logger;
    private readonly string _queueName = "church_month_work";
    public MonthWorkListener(IModel channel, ILogger logger)
    {
        _channel = channel;
        _logger = logger;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            await ExecuteConsume(stoppingToken);
        }
        catch (Exception ex) when (ex is BrokerUnreachableException || ex is OperationInterruptedException)
        {
            _logger.Error("An error with rabbitMq configs occurred before the connection: {0}", ex.Message);
        }
        catch (Exception ex)
        {
            _logger.Error("An error occurred before the connection: {0}", ex.Message);
        }

        while (true)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(1_000);
        }
    }
    private async Task ExecuteConsume(CancellationToken stoppingToken)
    {
        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += OnMessageReceived;
        _channel.BasicConsume(_queueName, false, consumer);

        while (!stoppingToken.IsCancellationRequested)
            await Task.Delay(1000, stoppingToken);

        _logger.Warning("Dispose connection");
        _channel.Dispose();
    }
    private async void OnMessageReceived(object? sender, BasicDeliverEventArgs eventsArgs)
    {
        try
        {
            byte[] rawMessage = eventsArgs.Body.ToArray();
            string message = Encoding.UTF8.GetString(rawMessage);
            MonthWorkMessageDto? objMessage = JsonSerializer.Deserialize<MonthWorkMessageDto>(message);

            if (objMessage is null)
                throw new ArgumentNullException();

            GenerateReporteMonthClose(objMessage);

            _channel.BasicAck(eventsArgs.DeliveryTag, false);
            _logger.Information($"Message newUserCreated processed successful. ChurchId - {objMessage.churchId}");
        }
        catch (Exception ex) when (ex is JsonException || ex is ArgumentNullException)
        {
            _logger.Error("There was an error deserializing the message: {0}. On MonthWorkListener", ex.Message);
            _channel.BasicNack(eventsArgs.DeliveryTag, false, false);
        }
        catch (Exception ex)
        {
            _logger.Error("There was an error processing the message: {0}. On MonthWorkListener", ex.Message);
            _channel.BasicNack(eventsArgs.DeliveryTag, false, false);
        }
    }

    private void GenerateReporteMonthClose(MonthWorkMessageDto objMessage)
    {
        if(objMessage is null)
            return;

        var report = new Report(null, objMessage.churchId, objMessage.YearMonth);
        List<Entitie.MonthlyClosing>? docReport = report.Generate().Result;
    }
}
