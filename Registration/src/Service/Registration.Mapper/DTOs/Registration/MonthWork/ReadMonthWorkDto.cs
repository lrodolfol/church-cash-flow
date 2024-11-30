namespace Registration.Mapper.DTOs.Registration.MonthWork;
public class ReadMonthWorkDto : ModelDto
{
    public string YeahMonth { get; set; } = null!;
    public string Church { get; set; } = null!;
    public int ChurchId { get; set; }
    public decimal InitialValue { get; set; }
    public decimal FinalValue { get; set; }
}
