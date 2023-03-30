using Flunt.Notifications;
using Flunt.Validations;

namespace Registration.Mapper.DTOs.Member;
public class EditMemberDto : ModelDto
{
    public string Name { get; set; }
    public DateTime DateBirth { get; set; }
    public int ChurchId { get; set; }
    public int PostId { get; set; }

    public void Validate()
    {
        DateTime t;
        if (!DateTime.TryParse(DateBirth.ToString(), out t))
            AddNotification("DateBitch", "The DateBirth is a invalid datetime");

        AddNotifications(new Contract<Notification>()
            .IsLowerThan(Name, 50, "Name", "Name should have no more than 50 chars")
            .IsGreaterThan(Name, 2, "Name", "Name should have at least 3 chars")
            .IsNotNull(ChurchId, "ChurchId", "Church Id cannot empty")
            .IsNotNull(PostId, "PostId", "Post Id cannot empty")
            );
    }
}