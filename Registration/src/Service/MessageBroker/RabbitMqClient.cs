using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace MessageBroker
{
    public class RabbitMqClient<T> : IMessageBrokerClient where T : BaseMessageBrokerClient
    {
        private readonly T ModelMessage;
        private IConnection _connection;
        private IModel _channel;
        private string _queueName;
        private string _queueNameDeadLeatter;
        
        public RabbitMqClient(T modelMessage)
        {
            ModelMessage = modelMessage;

            var connFactory = CreateConnectionFromParameters();

            _connection = connFactory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.ExchangeDeclare($"{ModelMessage.Exchange}_dead_leatter", ExchangeType.Topic, ModelMessage.Durable, ModelMessage.AutoDelete, null);
            _queueNameDeadLeatter = _channel.QueueDeclare($"{ModelMessage.Queue}_dead_leatter", ModelMessage.Durable, ModelMessage.Exclusive, ModelMessage.AutoDelete, null);
            _channel.QueueBind(_queueNameDeadLeatter, ModelMessage.ExchangeDeadLeatter, ModelMessage.RoutingKeyDeadLeatter, null);


            _channel.ExchangeDeclare(ModelMessage.Exchange, ExchangeType.Topic, ModelMessage.Durable, ModelMessage.AutoDelete, null);
            var args = new Dictionary<string, object>
            {
                { "x-dead-letter-exchange", $"{ModelMessage.ExchangeDeadLeatter}" },
                { "x-dead-letter-routing-key", ModelMessage.RoutingKeyDeadLeatter }
            };
            _queueName = _channel.QueueDeclare(ModelMessage.Queue, ModelMessage.Durable, ModelMessage.Exclusive, ModelMessage.AutoDelete, args);
            _channel.QueueBind(_queueName, ModelMessage.Exchange, ModelMessage.RoutingKey, null);

            _connection.ConnectionShutdown += ConnectionShutDown;
        }

        private ConnectionFactory CreateConnectionFromParameters()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = ModelMessage.Host,
                UserName = ModelMessage.UserName,
                Password = ModelMessage.Password,
                Port = int.Parse(ModelMessage.Port!.Trim())
            };

            if (someValueIsEmptyOrNull())
                throw new ArgumentNullException("Check the messageBroker properties");

            return connectionFactory;
        }

        private bool someValueIsEmptyOrNull() => (string.IsNullOrEmpty(ModelMessage.Host) |
                string.IsNullOrEmpty(ModelMessage.UserName) |
                string.IsNullOrEmpty(ModelMessage.Password) |
                string.IsNullOrEmpty(ModelMessage.Port));
        

        public void Publish()
        {
            
            _channel.BasicPublish(ModelMessage.Exchange, ModelMessage.RoutingKey, null, ModelMessage.BodyMessage);
        }


        private void ConnectionShutDown(object? sender, EventArgs e)
        {
            Console.WriteLine("MessageBroker connection shutdown");
        }
    }
}