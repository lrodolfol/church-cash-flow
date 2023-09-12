using HandlersTest.Builders.Dtos;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.MemberOut;

namespace HandlersTest.Builders.Entities;

public class MemberOutTest
{
    public static MemberOut ValidObjectOne() =>
        ConvertTo(EditMemberOutDtoTest.ValidObjectOne());
    public static MemberOut ValidObjectTwo() =>
        ConvertTo(EditMemberOutDtoTest.ValidObjectTwo());

    private static MemberOut ConvertTo(EditMemberOutDto dto) =>
        new MemberOut(dto.Reason, dto.Day, dto.MemberId);
}