using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Tithes;

namespace Registration.Mapper.Profiles;

public class TithesProfile : Profile
{
    public TithesProfile()
    {
        CreateMap<Tithes, ReadTithesDto>()
            .ForMember(read => read.Church, map =>
                map.MapFrom(tithes => tithes.Church!.Name))

            .ForMember(read => read.Member, map =>
                map.MapFrom(tithes => tithes.Member!.Name))

            .ForMember(read => read.OfferingKind, map =>
                map.MapFrom(tithes => tithes.OfferingKind!.Name))

            .ForMember(read => read.MemberId, map =>
                map.MapFrom(tithes => tithes.Member!.Id))

            .ForMember(read => read.OfferingKindId, map =>
                map.MapFrom(tithes => tithes.OfferingKind!.Id))
            ;
        CreateMap<EditTithesDto, Tithes>();
    }
}
