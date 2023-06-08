using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Church;
using Registration.Mapper.DTOs.ChurchAddress;

namespace ChurchCashFlow.Profiles;
public class ChurchProfile : Profile
{
    public ChurchProfile()
    {
        CreateMap<Church, ReadChurchDto>()
            .ForMember(church => church.FirstTreasurer, map =>
            map.MapFrom(read => read.FirstTreasurer!.Name))

            .ForMember(church => church.SecondTreasurer, map =>
            map.MapFrom(read => read.SecondTreasurer!.Name))

            .ForMember(church => church.FirstSecretary, map =>
            map.MapFrom(read => read.FirstSecretary!.Name))

            .ForMember(church => church.SecondSecretary, map =>
            map.MapFrom(read => read.SecondSecretary!.Name))

            .ForMember(church => church.FirstPastor, map =>
            map.MapFrom(read => read.FirstPastor!.Name))

            .ForMember(church => church.SecondPastor, map =>
            map.MapFrom(read => read.SecondPastor!.Name));

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