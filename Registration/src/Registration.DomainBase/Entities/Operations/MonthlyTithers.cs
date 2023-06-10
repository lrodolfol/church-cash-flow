namespace Registration.DomainBase.Entities.Operations;

public class MonthlyTithers
{
    public string? Name { get; private set; }
    public DateOnly TitheDate { get; private set; }
    public string Competence { get; private set; }
    public decimal TotalAmount { get; private set; }
}
