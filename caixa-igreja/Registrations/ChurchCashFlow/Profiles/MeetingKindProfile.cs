using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.MeetingKind;
using DataModelChurchCashFlow.Models.Entities;

namespace ChurchCashFlow.Profiles;
public class MeetingKindProfile : Profile
{
    public MeetingKindProfile()
    {
        CreateMap<MeetingKind, ReadMeetingKindDto>();
        CreateMap<EditMeetingKindDto, MeetingKind>();
    }
}
