using Registration.DomainCore.ViewModel;

namespace Registration.Mapper.DTOs.OutFlow;
public class ReadOutFlowDto : ModelDto
{
    public DateTime Day { get; private set; }
    public string MonthYear { get; private set; } //competencia (12/2023)
    public bool Authorized { get; private set; } = true;
    public decimal Amount { get; private set; }
    public decimal Interest { get; private set; }
    public decimal Discount { get; private set; }
    public decimal TotalAmount { get; private set; }
    public string OutFlow { get; private set; }
    public string Church { get; private set; }
}