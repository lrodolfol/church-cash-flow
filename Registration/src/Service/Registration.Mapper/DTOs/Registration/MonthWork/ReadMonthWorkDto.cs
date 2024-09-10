namespace Registration.Mapper.DTOs.Registration.MonthWork;
public class ReadMonthWorkDto : ModelDto
{
    public string YeahMonth { get; set; } = null!;
    public bool Block { get; set; }
    public string Church { get; set; } = null!;
    public int ChurchId { get; set; }
}
