using Flunt.Notifications;

namespace ChurchCashFlow.Data.ViewModels.Dtos;

public abstract class ModelDto : Notifiable<Notification>
{
    public DateTime DateRequest
    {
        get
        {
            return DateTime.UtcNow;
        }
    }

    public List<string> GetNotification()
    {
        var allNotification = Notifications.ToList();

        return (from n in allNotification
                select n.Message).ToList();
    }

    
}
