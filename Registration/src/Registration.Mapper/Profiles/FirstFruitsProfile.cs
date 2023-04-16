using AutoMapper;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.FirstFruits;
using Registration.Mapper.DTOs.Tithes;

namespace Registration.Mapper.Profiles;

public class FirstFruitsProfile : Profile
{
    public FirstFruitsProfile()
    {
        CreateMap<FirstFruits, ReadFirstFruitsDto>()
            .ForMember(read => read.Church, map =>
                map.MapFrom(fruits => fruits.Church.Name))
            .ForMember(read => read.Member, map =>
                map.MapFrom(fruits => fruits.Member.Name))
            .ForMember(read => read.OfferingKind, map =>
                map.MapFrom(fruits => fruits.OfferingKind.Name));
        CreateMap<EditFirstFruitsDto, FirstFruits>();
    }
}
