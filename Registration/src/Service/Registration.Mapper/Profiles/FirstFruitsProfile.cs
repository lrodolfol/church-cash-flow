using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.FirstFruits;

namespace Registration.Mapper.Profiles;

public class FirstFruitsProfile : Profile
{
    public FirstFruitsProfile()
    {
        CreateMap<FirstFruits, ReadFirstFruitsDto>()
            .ForMember(read => read.Church, map =>
                map.MapFrom(fruits => fruits.Church!.Name))
            .ForMember(read => read.Member, map =>
                map.MapFrom(fruits => fruits.Member!.Name))
            .ForMember(read => read.OfferingKind, map =>
                map.MapFrom(fruits => fruits.OfferingKind!.Name))
            .ForMember(read => read.MemberId, map =>
                map.MapFrom(fruits => fruits.Member!.Id))
            .ForMember(read => read.OfferingKindId, map =>
                map.MapFrom(fruits => fruits.OfferingKind!.Id));

        CreateMap<EditFirstFruitsDto, FirstFruits>();
    }
}
