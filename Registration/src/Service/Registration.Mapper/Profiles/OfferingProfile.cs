using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Offering;

namespace ChurchCashFlow.Profiles;
public class OfferingProfile : Profile
{
    public OfferingProfile()
    {
        CreateMap<Offering, ReadOfferingDto>()
             .ForMember(read => read.Church, map =>
                map.MapFrom(offering => offering.Church!.Name))
            .ForMember(read => read.MeetingKind, map =>
                map.MapFrom(offering => offering.MeetingKind!.Name))
            .ForMember(read => read.OfferingKind, map =>
                map.MapFrom(offering => offering.OfferingKind!.Name));
        CreateMap<EditOfferingDto, Offering>();
    }
}
