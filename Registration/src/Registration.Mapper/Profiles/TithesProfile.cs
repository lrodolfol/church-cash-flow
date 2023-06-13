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
                map.MapFrom(tithes => tithes.Church.Name))
            .ForMember(read => read.Member, map =>
                map.MapFrom(tithes => tithes.Member.Name))
            .ForMember(read => read.OfferingKind, map =>
                map.MapFrom(tithes => tithes.OfferingKind.Name));
        CreateMap<EditTithesDto, Tithes>();
    }
}
