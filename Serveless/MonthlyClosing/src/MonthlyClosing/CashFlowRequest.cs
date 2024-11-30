namespace MonthlyClosing;

public class Model
{
    public int ChurchId { get; set; }
    public string ChurchName { get; set; } = null!;
    public string Competence { get; set; } = null!;
    public string OcurredOn { get; set; } = null!;
    public List<FlowJsonFile> FlowJsonFile { get; set; } = [];
}

public class FlowJsonFile
{
    public string Competence { get; set; }
    public DateTime Day { get; set; }
    public decimal PreviousBalance { get; set; }
    public decimal CurrentBalance { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal AmountInputOperation { get; set; }
    public decimal AmountOutPutOperation { get; set; }
    public decimal TotalOperation { get; set; }
}
