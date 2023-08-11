namespace Registration.Mapper.DTOs.Registration.MemberOut;

public class ReadMemberIn : ModelDto
{
    public int MemberId { get; set; }
    public string ChurchName { get; set; } = null!;
    public string LastPost { get; set; } = null!;
    public string LetterReceiver { get; set; } = null!;

}