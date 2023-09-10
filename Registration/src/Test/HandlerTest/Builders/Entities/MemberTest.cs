using HandlersTest.Builders.Dtos;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Member;

namespace HandlersTest.Builders.Entities;

public class MemberTest
{
    public static Member ValidObjectOne() =>
        ConvertTo(EditMemberDtoTest.ValidObjectOne());

    public static Member ValidObjectTwo() =>
        ConvertTo(EditMemberDtoTest.ValidObjectTwo());

    public static Member InValidObjectOne() =>
        ConvertTo(EditMemberDtoTest.InvalidObjectOne());


    private static Member ConvertTo(EditMemberDto dto) =>
        new Member(dto.Id, dto.Name!, dto.DateBirth, dto.DateBaptism, dto.ChurchId, "", dto.DateRegister);
}