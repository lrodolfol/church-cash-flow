using Flunt.Notifications;
using Flunt.Validations;

namespace Registration.Mapper.DTOs.Registration.FirstFruits;
public class EditFirstFruitsDto : ModelDto
{
    public decimal TotalAmount { get; set; }
    public DateTime Day { get; set; }
    public string? Description { get; set; }
    public string? Competence { get; set; }
    public int ChurchId { get; set; }
    public int OfferingKindId { get; set; }
    public int MemberId { get; set; }
    public string? base64Image { get; set; }

    public void Validate()
    {
        DateTime t;
        if (!DateTime.TryParse(Day.ToString(), out t))
            AddNotification("Day", "The Day is a invalid datetime");

        if (Day > DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")))
            AddNotification("Day", "Day cannot be greater than today");

        if (!CompetenceIsValid())
            AddNotification("Competence", "Competence is invalis or greater than today");

        AddNotifications(new Contract<Notification>()
            .IsNotNull(ChurchId, "ChurchId", "Church Id cannot empty")
            .IsNotNull(OfferingKindId, "OfferingKindId", "OfferingKind Id cannot empty")
            .IsNotNull(MemberId, "MemberId", "Member Id cannot empty")
            .IsGreaterThan(TotalAmount, 0, "TotalAmount", "Total Amount must be")
            .IsNotNullOrEmpty(Description, "Description", "Description cannot be empty")
            .IsLowerThan(Description, 75, "Description", "Description should between 0 and 75 characters")
            );
    }

    private bool CompetenceIsValid()
    {
        try
        {
            var dt = DateTime.Parse(Competence!).ToString("yyyy/MM");
            Competence = dt;
        }
        catch
        {
            AddNotification("Competence", "Competence is invalid");
            return false;
        }

        var tryCompetence = DateTime.Parse(Competence);
        if (tryCompetence > DateTime.Parse(DateTime.Now.ToString("MM/yyyy")))
            return false;

        return true;
    }
}