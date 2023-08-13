using Registration.Mapper.DTOs.Registration.MemberIn;
using Registration.Mapper.DTOs.Registration.MemberOut;
using Registration.Mapper.DTOs.Registration.MemberPost;

namespace Registration.Mapper.DTOs.Registration.Member;
public class ReadMemberDto : ModelDto
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Photo { get; set; }
    public DateTime? DateBirth { get; set; }
    public DateTime? DateBaptism { get; set; }
    public DateTime? DateRegister { get; set; }
    public string? Description { get; set; }
    public string? Church { get; set; }
    //public string[]? MemberPosts { get; set; }
    public ReadMemberOut? MemberOut { get; set; }
    public ReadMemberInDto? MemberIn { get; set; }
    public List<ReadMemberPost>? MemberPost { get; set; }
    
}