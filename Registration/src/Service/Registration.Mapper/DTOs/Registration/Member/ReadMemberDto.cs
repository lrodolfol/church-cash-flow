namespace Registration.Mapper.DTOs.Registration.Member;
public class ReadMemberDto : ModelDto
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Photo { get; set; }
    public DateTime? DateBirth { get; set; }
    public DateTime? DateBaptism { get; set; }
    public string? Church { get; set; }
    public string? Post { get; set; }
    public string[]? MemberPosts { get; set; }
}