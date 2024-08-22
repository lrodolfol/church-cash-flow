using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.MeetingKind;

namespace Registration.Mapper.Profiles;
public class MeetingKindProfile : Profile
{
    public MeetingKindProfile()
    {
        CreateMap<MeetingKind, ReadMeetingKindDto>();
        CreateMap<EditMeetingKindDto, MeetingKind>();
    }
}
