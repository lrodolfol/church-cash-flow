namespace Registration.DomainCore.Events;
public class UserCreatedEvent : DomainBaseEvents
{
    public int Id { get; set; }
    public string EmailAddress { get; set; } = null!;

    public UserCreatedEvent(int id, string emailAddress) : base()
    {
        Id = id;
        EmailAddress = emailAddress;
    }
}
