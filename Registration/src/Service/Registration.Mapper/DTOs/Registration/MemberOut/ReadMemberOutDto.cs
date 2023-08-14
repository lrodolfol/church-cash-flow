namespace Registration.Mapper.DTOs.Registration.MemberOut;

public class ReadMemberOutDto : ModelDto
{
    public int MemberId { get; set; }
    public string Reason { get; set; } = null!;
    public DateOnly Day { get; set; }
}