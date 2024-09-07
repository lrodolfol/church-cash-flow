using ConsumerChurchMonthWork.Models;
using Microsoft.Extensions.Hosting;
using Serilog;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using RabbitMQ.Client.Exceptions;
using System.Security.Cryptography;
using ConsumerChurchMonthWork.Services;

namespace ConsumerChurchMonthWork.MessageBrocker.Consumer;
public class NewUserCreatedListerner : BackgroundService
{
    private readonly IModel _channel;
    private readonly ILogger _logger;
    private readonly string _queueName = "user_created";
    public NewUserCreatedListerner(IModel channel, ILogger logger)
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
        catch(Exception ex) when (ex is BrokerUnreachableException || ex is OperationInterruptedException)
        {
            _logger.Error("An error with rabbitMq configs occurred before the connection: {0}", ex.Message);
        }
        catch (Exception ex)
        {
            _logger.Error("An error occurred before the connection: {0}", ex.Message);
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
            UserCreatedMessageDto? objMessage = JsonSerializer.Deserialize<UserCreatedMessageDto>(message);

            if(objMessage is null || objMessage.EmailAddress is null)
                throw new ArgumentNullException();

            //await new SendEmailNewUser().SendEmailAsync(objMessage);

            _channel.BasicAck(eventsArgs.DeliveryTag, false);
            _logger.Information($"Message newUserCreated processed successful. User Email - {objMessage.EmailAddress}");
        }
        catch(Exception ex) when (ex is JsonException || ex is ArgumentNullException)
        {
            _logger.Error("There was an error deserializing the message: {0}. On newUserCreated", ex.Message);
            _channel.BasicNack(eventsArgs.DeliveryTag, false, false);
        }
        catch (Exception ex)
        {
            _logger.Error("There was an error processing the message: {0}. On newUserCreated", ex.Message);
            _channel.BasicNack(eventsArgs.DeliveryTag, false, false);
        }
    }
}
