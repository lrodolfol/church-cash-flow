using Flunt.Notifications;
using Flunt.Validations;

namespace Registration.Mapper.DTOs.Offering;
public class EditOfferingDto : ModelDto
{
    public DateTime Day { get; set; }
    public int AdultQuantity { get; set; }
    public int ChildrenQuantity { get; set; } = 0;
    public decimal TotalAmount { get; set; } = 0;
    public string? PreacherMemberName { get; set; }
    public int MeetingKindId { get; set; }
    public int OfferingKindId { get; set; }
    public int ChurchId { get; set; }

    public void Validate()
    {
        DateTime t;
        if (!DateTime.TryParse(Day.ToString(), out t))
            AddNotification("DateBitch", "The DateBirth is a invalid datetime");

        if (Day > DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")))
            AddNotification("Day", "Day cannot be greater than today");

        AddNotifications(new Contract<Notification>()
            .IsNotNullOrEmpty(PreacherMemberName, "PreacherMemberName", "The preacher member cannot be empty")
            .IsNotNull(AdultQuantity, "AdultQuantity", "AdultQuantity Id cannot empty")
            .IsNotNull(OfferingKindId, "OfferingKindId", "OfferingKindId Id cannot empty")
            .IsNotNull(ChurchId, "ChurchId", "ChurchId Id cannot empty")
            );
    }
}