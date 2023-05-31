using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.MeetingKind;

namespace ChurchCashFlow.Profiles;
public class MeetingKindProfile : Profile
{
    public MeetingKindProfile()
    {
        CreateMap<MeetingKind, ReadMeetingKindDto>();
        CreateMap<EditMeetingKindDto, MeetingKind>();
    }
}
