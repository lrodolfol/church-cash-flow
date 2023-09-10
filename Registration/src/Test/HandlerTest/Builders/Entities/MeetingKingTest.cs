using HandlersTest.Builders.Dtos;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.MeetingKind;

namespace HandlersTest.Builders.Entities;

public class MeetingKingTest
{
    public static MeetingKind ValidObjectOne() =>
        ConvertTo(EditMeetingKidDtoTest.ValidObjectOne());
    public static MeetingKind ValidObjectTwo() =>
    ConvertTo(EditMeetingKidDtoTest.ValidObjectTwo());

    public static MeetingKind ValidObjectThree() =>
    ConvertTo(EditMeetingKidDtoTest.ValidObjectThree());

    public static MeetingKind ValidObjectFour() =>
    ConvertTo(EditMeetingKidDtoTest.ValidObjectFour());

    public static MeetingKind ValidObjectFive() =>
    ConvertTo(EditMeetingKidDtoTest.ValidObjectFive());

    private static MeetingKind ConvertTo(EditMeetingKindDto dto) =>
        new MeetingKind(dto.Id, dto.Name!, dto.Description!);
}