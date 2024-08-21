using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.OutFlow;

namespace Registration.Mapper.Profiles;
public class OutFlowProfile : Profile
{
    public OutFlowProfile()
    {
        CreateMap<OutFlow, ReadOutFlowDto>()
            .ForMember(read => read.OutFlow, map =>
            map.MapFrom(outFlow => outFlow.OutFlowKind.Name))
            .ForMember(read => read.Church, map =>
            map.MapFrom(outFlow => outFlow.Church.Name));
        CreateMap<EditOutFlowDto, OutFlow>();
    }
}