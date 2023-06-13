namespace Registration.DomainBase.Entities.Operations;

public class MonthlyTithers
{
    public string? Name { get; set; }
    public DateTime Day { get; set; }
    public string? Competence { get; set; }
    public decimal TotalAmount { get; set; }
}
