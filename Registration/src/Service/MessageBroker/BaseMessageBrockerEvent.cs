namespace MessageBroker;
public abstract class BaseMessageBrockerEvent
{
    public abstract Task PreparePublish(DomainBaseEvents _domainEvent);
}
