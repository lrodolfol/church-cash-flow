using Registration.Mapper.DTOs.Registration.MeetingKind;

namespace HandlersTest.Builders.Dtos;

public class EditMeetingKidDtoTest
{
    public static EditMeetingKindDto ValidObjectOne() =>
        new EditMeetingKindDto() { Name = "Culto do poder", Description = "Culto do poder e unção" };
    public static EditMeetingKindDto ValidObjectTwo() =>
        new EditMeetingKindDto() { Name = "Culto da prosperidade", Description = "Culto da ministração de prosperidade" };
    public static EditMeetingKindDto ValidObjectThree() =>
        new EditMeetingKindDto() { Name = "Culto do Missão", Description = "Culto da ministração de missões" };
    public static EditMeetingKindDto ValidObjectFour() =>
        new EditMeetingKindDto() { Name = "Culto da centésima ovelha", Description = "Culto de levar amigos no culto" };
    public static EditMeetingKindDto ValidObjectFive() =>
        new EditMeetingKindDto() { Name = "Culto de santa ceia", Description = "Culto da ministação de santa ceia" };
}