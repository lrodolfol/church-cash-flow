namespace Registration.Mapper.DTOs.Registration.OutFlow;
public class ReadOutFlowDto : ModelDto
{
    public DateTime Day { get; private set; }
    public string? Competence { get; private set; } //competencia (12/2023)
    public string? Description { get; private set; }
    public bool Authorized { get; private set; } = true;
    public decimal Amount { get; private set; }
    public decimal Interest { get; private set; }
    public decimal Discount { get; private set; }
    public decimal TotalAmount { get; private set; }
    public string? OutFlow { get; private set; }
    public string? Church { get; private set; }
    public string? Photo { get; private set; }
    public int OutFlowKindId { get; set; }
}