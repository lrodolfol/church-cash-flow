using Flunt.Notifications;
using Flunt.Validations;

namespace Registration.Mapper.DTOs.Registration.MonthWork;
public class EditMonthWorkDto : ModelDto
{
    public int YearMonth { get; set; }
    public int ChurchId { get; set; }

    public void Validate()
    {
        var checkDate = ChechYearMonth();
        if (!checkDate.Validated)
            AddNotification("YearMonth", checkDate.Message);

        AddNotifications(new Contract<Notification>()
            .IsNotNull(ChurchId, "ChurchId", "ChurchId Id cannot empty")
            );
    }

    private (bool Validated, string Message) ChechYearMonth()
    {
        var year = YearMonth.ToString().Substring(0, 4);
        var month = YearMonth.ToString().Substring(4, YearMonth.ToString().Length - 4);
        var dateComplete = year + "-" + month + "-01";

        DateTime dateParsed;
        if (!DateTime.TryParse(dateComplete, out dateParsed))
            return (false, "The period is invalid");

        if(dateParsed > DateTime.Now)
            return (false, "The period is greater than the current data");

        return (true, "");
    }
}