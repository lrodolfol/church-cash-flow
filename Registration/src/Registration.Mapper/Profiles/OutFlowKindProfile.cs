using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.OutFlowKind;

namespace ChurchCashFlow.Profiles;
public class OutFlowKindProfile : Profile
{
    public OutFlowKindProfile()
    {
        CreateMap<OutFlowKind, ReadOutFlowKindDto>();
        CreateMap<EditOutFlowKindDto, OutFlowKind>();
    }
}