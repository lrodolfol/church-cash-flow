namespace Registration.DomainBase.Entities;
public class OutFlow : Entitie
{
    public DateTime? Day { get; private set; }
    public string? MonthYear { get; private set; } //competencia (12/2023)
    public string? Description { get; private set; }
    public bool? Authorized { get; private set; }
    public decimal Amount { get; private set; }
    public decimal Interest { get; private set; }
    public decimal Discount { get; private set; }
    public decimal TotalAmount { get; private set; }
    public int OutFlowKindId { get; private set; }
    public OutFlowKind? OutFlowKind { get; private set; }
    public int ChurchId { get; private set; }
    public Church? Church { get; set; }

    public OutFlow(int id, DateTime day, string monthYear, string description, int outFlowKindId, int churchId, decimal amount, decimal interest = 0, decimal discount = 0, bool authorized = true)
    {
        Id = id;
        Day = day;
        MonthYear = monthYear;
        Description = description;
        Authorized = authorized;
        Amount = amount;
        Interest = interest;
        Discount = discount;
        OutFlowKindId = outFlowKindId;
        ChurchId = churchId;
    }

    public OutFlow()
    {
    }

    public void CalculateTotalAmount()
    {
        TotalAmount = ((Amount + Interest) - Discount);
    }

    public void UpdateChanges(OutFlow editOutFlow)
    {
        Day = editOutFlow.Day;
        MonthYear = editOutFlow.MonthYear;
        Description = editOutFlow.Description;
        Authorized = editOutFlow.Authorized;
        Amount = editOutFlow.Amount;
        Interest = editOutFlow.Interest;
        Discount = editOutFlow.Discount;
        OutFlowKindId = editOutFlow.OutFlowKindId;
        ChurchId = editOutFlow.ChurchId;
        
        CalculateTotalAmount();
    }
}
