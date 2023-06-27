using Flunt.Notifications;
using Flunt.Validations;

namespace Registration.Mapper.DTOs.Registration.MonthWork;
public class EditMonthWorkDto : ModelDto
{
    public int YearMonth { get; set; }
    public bool Block { get; set; }
    public int ChurchId { get; set; }

    public void Validate()
    {
        if (!ChechYearMonth())
            AddNotification("YearMonth", "The period is invalid");

        AddNotifications(new Contract<Notification>()
            .IsNotNull(ChurchId, "ChurchId", "ChurchId Id cannot empty")
            );
    }

    private bool ChechYearMonth()
    {
        var year = YearMonth.ToString().Substring(0, 4);
        var month = YearMonth.ToString().Substring(4, YearMonth.ToString().Length - 4);
        var dateComplete = year + "-" + month + "-01";

        DateTime t;
        if (DateTime.TryParse(dateComplete, out t))
            return true;

        return false;
    }
}