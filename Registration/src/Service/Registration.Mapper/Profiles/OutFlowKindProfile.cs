using AutoMapper;
using Registration.DomainBase.Entities.Registrations.sql;
using Registration.Mapper.DTOs.Registration.OutFlowKind;

namespace ChurchCashFlow.Profiles;
public class OutFlowKindProfile : Profile
{
    public OutFlowKindProfile()
    {
        CreateMap<OutFlowKind, ReadOutFlowKindDto>();
        CreateMap<EditOutFlowKindDto, OutFlowKind>();
    }
}