namespace MonthlyClosing;
public class MonthOpenedRequest
{
    public int ChurchId { get; set; }
    public string ChurchName { get; set; } = null!;
    public string Competence { get; set; } = null!;
    public string OcurredOn { get; set; } = null!;
}
