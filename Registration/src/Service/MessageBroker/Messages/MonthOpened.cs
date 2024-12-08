using MessageBroker.SQS;
using Registration.CentralPackages;
using Registration.DomainCore.Events;
using System.Text.Json;

namespace MessageBroker.Messages;
public class MonthOpened : SQSBaseEvent
{
    private MonthlyOpenedEvent _domainEnvent = null!;
    private string QueueName = ConfigurationBridge.AwsCloudConfiguration.Sqs.monthlyOpeningQueueName;

    public override async Task PreparePublish(DomainBaseEvents @event)
    {
        _domainEnvent = (MonthlyOpenedEvent)@event;
        BuildMessage();

        IMessageBrokerClient client = new SQSClient<MonthOpened>(this, QueueName);

        await client.Publish();
    }

    public void BuildMessage() =>
        BodyMessage = JsonSerializer.Serialize(_domainEnvent);
}
