using Flunt.Notifications;

namespace Registration.DomainCore.ViewModelAbstraction;
public abstract class CModelDTO : Notifiable<Notification>
{
    public int Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTime DateRequest => DateTime.UtcNow;

    public List<string> GetNotification()
    {
        var allNotification = Notifications.ToList();

        return (from n in allNotification
                select n.Message).ToList();
    }
}