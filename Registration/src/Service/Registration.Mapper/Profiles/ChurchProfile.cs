using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Church;
using Registration.Mapper.DTOs.Registration.ChurchAddress;

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