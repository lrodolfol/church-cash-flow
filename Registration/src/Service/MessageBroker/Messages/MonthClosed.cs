﻿using MessageBroker.SQS;
using Registration.CentralPackages;
using Registration.DomainCore.Events;
using System.Text.Json;

namespace MessageBroker.Messages;

public class MonthClosed : SQSBaseEvent
{
    private MonthlyClosedEvent _domainEnvent = null!;
    private string QueueName = ConfigurationBridge.AwsCloudConfiguration.Sqs.monthlyClosingQueueName;

    public override async Task PreparePublish(DomainBaseEvents @event)
    {
        _domainEnvent = (MonthlyClosedEvent)@event;
        BuildMessage();

        IMessageBrokerClient client = new SQSClient<MonthClosed>(this, QueueName);

        await client.Publish();
    }

    public void BuildMessage() =>
        BodyMessage = JsonSerializer.Serialize(_domainEnvent);
}
