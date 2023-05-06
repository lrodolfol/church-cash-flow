namespace ConsumerChurchMonthWork.Entitie;

public sealed class MonthlyClosing
{
    public string Compentece { get; set; } = string.Empty;
    public int Day { get; private set; }
    public decimal PreviousBalance { get; set; }
    public decimal CurrentBalance { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal AmountInputOperation { get; set; }
    public decimal AmountOutPutOperation { get; set; }
    public decimal TotalOperation { get; set; }
    public string Church { get; set; }
}
