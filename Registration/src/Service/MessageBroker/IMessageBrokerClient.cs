namespace MessageBroker;

public interface IMessageBrokerClient
{
    public Task Publish();
}
