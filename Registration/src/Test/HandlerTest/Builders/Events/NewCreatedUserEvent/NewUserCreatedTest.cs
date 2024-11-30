using MessageBroker.RabbitMq;
using Microsoft.Extensions.Configuration;

namespace HandlersTest.Builders.Events.NewCreatedUserEvent;
internal class NewUserCreatedTest : RabbitMqBaseEvent
{
    public NewUserCreatedTest(IConfiguration configuration) : base(configuration)
    {
    }

    public override async Task PreparePublish(DomainBaseEvents _domainEvent)
    {
        return;
    }

    protected override byte[] BuildMessage()
    {
        return new byte[0];
    }

    protected override void LoadConfig()
    {
        return;
    }
}
