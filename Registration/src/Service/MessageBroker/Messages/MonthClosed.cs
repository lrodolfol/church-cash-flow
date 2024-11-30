using MessageBroker.SQS;
using Registration.DomainCore.Events;
using System.Text.Json;

namespace MessageBroker.Messages;

public class MonthClosed : SQSBaseEvent
{
    private monthlyClosedEvents _domainEnvent = null!;

    public override async Task PreparePublish(DomainBaseEvents @event)
    {
        _domainEnvent = (monthlyClosedEvents)@event;
        BuildMessage();

        IMessageBrokerClient client = new SQSClient<MonthClosed>(this);

        await client.Publish();
    }

    public void BuildMessage() =>
        BodyMessage = JsonSerializer.Serialize(_domainEnvent);
}
