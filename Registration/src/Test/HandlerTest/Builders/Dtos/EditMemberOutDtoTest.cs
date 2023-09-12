using HandlersTest.Builders.Entities;
using Registration.Mapper.DTOs.Registration.MemberOut;

namespace HandlersTest.Builders.Dtos;

public class EditMemberOutDtoTest
{
    public static EditMemberOutDto ValidObjectOne() =>
        new EditMemberOutDto() { MemberId = MemberTest.ValidObjectOne().Id, Reason = "Abandono" };

    public static EditMemberOutDto ValidObjectTwo() =>
        new EditMemberOutDto() { MemberId = MemberTest.ValidObjectTwo().Id, Reason = "Falecimento" };

    public static EditMemberOutDto InvalidObjectThree() =>
        new EditMemberOutDto() { MemberId = MemberTest.InValidObjectOne().Id, Reason = "Abandono" };
}