using Flunt.Notifications;
using Flunt.Validations;

namespace Registration.Mapper.DTOs.Registration.MemberOut;

public class EditMemberOutDto : ModelDto
{
    public int MemberId { get; set; }
    public string Reason { get; set; } = null!;
    public DateOnly Day { get; set; }

    public void Validate()
    {
        DateTime t;
        if ((!DateTime.TryParse(Day.ToString(), out t)) || Day.Year == 1)
            AddNotification("Day", "The Day is a invalid date");

        AddNotifications(new Contract<Notification>()
            .IsNotNullOrEmpty(Reason, "Reason", "Reason cannot be null")
            .IsNotNull(MemberId, "MemberId", "MemberId cannot be null")
            );
    }
}
