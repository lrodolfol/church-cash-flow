using AutoMapper;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Church;
using Registration.Mapper.DTOs.ChurchAddress;

namespace ChurchCashFlow.Profiles;
public class ChurchProfile : Profile
{
    public ChurchProfile()
    {
        CreateMap<Church, ReadChurchDto>();
        CreateMap<EditChurchDto, Church>();
        CreateMap<ChurchAddress, Church>()
            .ForMember(church => church.Name, map =>
            map.MapFrom(edit => edit.EditChurchDto.Name))
            .ForMember(church => church.Active, map =>
            map.MapFrom(edit => edit.EditChurchDto.Active))
            .ForMember(church => church.Acronym, map =>
            map.MapFrom(edit => edit.EditChurchDto.Acronym));
    }
}