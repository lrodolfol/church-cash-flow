namespace MessageBroker.SQS;
public abstract class SQSBaseEvent : BaseMessageBrockerEvent
{
    public string BodyMessage { get; protected set; } = string.Empty;
}
