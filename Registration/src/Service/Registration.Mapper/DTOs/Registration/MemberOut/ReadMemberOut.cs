namespace Registration.Mapper.DTOs.Registration.MemberOut;

public class ReadMemberOut : ModelDto
{
    public int MemberId { get; set; }
    public string Reason { get; set; } = null!;
    public DateOnly Day { get; set; }
}