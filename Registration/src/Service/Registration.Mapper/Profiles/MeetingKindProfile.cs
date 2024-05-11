using AutoMapper;
using Registration.DomainBase.Entities.Registrations.sql;
using Registration.Mapper.DTOs.Registration.MeetingKind;

namespace ChurchCashFlow.Profiles;
public class MeetingKindProfile : Profile
{
    public MeetingKindProfile()
    {
        CreateMap<MeetingKind, ReadMeetingKindDto>();
        CreateMap<EditMeetingKindDto, MeetingKind>();
    }
}
