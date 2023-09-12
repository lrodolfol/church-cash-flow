using HandlersTest.Builders.Entities;
using Registration.Mapper.DTOs.Registration.MemberIn;
using Registration.Mapper.DTOs.Registration.MemberOut;

namespace HandlersTest.Builders.Dtos;

public class EditMemberInDtoTest
{
    public static EditMemberInDto ValidObjectOne() =>
        new EditMemberInDto() { MemberId = MemberTest.ValidObjectOne().Id, ChurchName = "Sara Nossa Terra", 
            LastPost = PostTest.ValidObjectOne().Name!, LetterReceiver = "COM CARTA" };
        public static EditMemberInDto ValidObjectTwo() =>
        new EditMemberInDto() { MemberId = MemberTest.ValidObjectOne().Id, ChurchName = "Quadrangular", 
            LastPost = PostTest.ValidObjectOne().Name!, LetterReceiver = "COM CARTA" };

        public static EditMemberInDto ValidObjectThree() =>
        new EditMemberInDto() { MemberId = MemberTest.ValidObjectOne().Id, ChurchName = "Sara Nossa Terra", 
            LastPost = PostTest.ValidObjectOne().Name!, LetterReceiver = "COM CARTA" };
}