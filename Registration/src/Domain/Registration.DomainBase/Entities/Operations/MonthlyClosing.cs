namespace Registration.DomainBase.Entities.Operations;

public class MonthlyClosing
{
    public string? Competence { get; set; }
    public DateTime Day { get; private set; }
    public decimal PreviousBalance { get; set; }
    public decimal CurrentBalance { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public decimal AmountInputOperation { get; set; }
    public decimal AmountOutPutOperation { get; set; }
    public decimal TotalOperation { get; set; }
    public string? Church { get; set; }
}
