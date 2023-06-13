namespace Registration.DomainBase.Entities.Operations;

public class MonthlyFruiters
{
    public string Name { get; set; } = string.Empty;
    public DateTime Day { get; set; }
    public string? Competence { get; set; }
    public decimal TotalAmount { get; set; }
    public string OfferingName { get; set; } = string.Empty;
}
