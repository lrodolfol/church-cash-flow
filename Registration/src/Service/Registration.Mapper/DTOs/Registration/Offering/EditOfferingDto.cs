using Flunt.Notifications;
using Flunt.Validations;

namespace Registration.Mapper.DTOs.Registration.Offering;
public class EditOfferingDto : ModelDto
{
    public DateTime Day { get; set; }
    public string? Competence { get; set; }
    public int AdultQuantity { get; set; }
    public string? Description { get; set; }
    public int ChildrenQuantity { get; set; } = 0;
    public decimal TotalAmount { get; set; } = 0;
    public string? PreacherMemberName { get; set; }
    public int MeetingKindId { get; set; }
    public int OfferingKindId { get; set; }
    public int ChurchId { get; set; }
    public string? base64Image { get; set; }

    public void Validate()
    {
        DateTime t;
        if (!DateTime.TryParse(Day.ToString(), out t))
            AddNotification("DateBitch", "The DateBirth is a invalid datetime");

        if (Day > DateTime.Parse(DateTime.UtcNow.ToString("yyyy-MM-dd")))
            AddNotification("Day", "Day cannot be greater than today");

        if (!CompetenceIsValid())
            AddNotification("Day", "Day or Competence cannot be read. Try again");

        AddNotifications(new Contract<Notification>()
            .IsNotNullOrEmpty(PreacherMemberName, "PreacherMemberName", "The preacher member cannot be empty")
            .IsNotNull(AdultQuantity, "AdultQuantity", "AdultQuantity Id cannot empty")
            .IsNotNull(OfferingKindId, "OfferingKindId", "OfferingKindId Id cannot empty")
            .IsNotNull(ChurchId, "ChurchId", "ChurchId Id cannot empty")
            .IsNotNullOrEmpty(Description, "Description", "Description cannot be empty")
            .IsLowerThan(Description, 75, "Description", "Description should between 0 and 75 characters")
            );
    }

    private bool CompetenceIsValid()
    {
        try
        {
            var dt = Day.ToString("yyyy/MM");
            Competence = dt;
        }
        catch
        {
            AddNotification("Competence", "Competence is invalid");
            return false;
        }

        return true;
    }
}