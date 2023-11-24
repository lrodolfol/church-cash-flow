using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Church;
using Registration.Mapper.DTOs.Registration.ChurchAddress;

namespace ChurchCashFlow.Profiles;
public class ChurchProfile : Profile
{
    public ChurchProfile()
    {
        CreateMap<Church, ReadChurchDto>()
            .ForMember(church => church.FirstPastor, map =>
            map.MapFrom(edit => edit.FirstPastor.Name))
            .ForMember(church => church.SecondPastor, map =>
            map.MapFrom(edit => edit.SecondPastor.Name))

            .ForMember(church => church.FirstSecretary, map =>
            map.MapFrom(edit => edit.FirstSecretary.Name))
            .ForMember(church => church.SecondSecretary, map =>
            map.MapFrom(edit => edit.SecondSecretary.Name))

            .ForMember(church => church.FirstTreasurer, map =>
            map.MapFrom(edit => edit.FirstTreasuser.Name))
            .ForMember(church => church.SecondTreasurer, map =>
            map.MapFrom(edit => edit.SecondTreasuser.Name));

        CreateMap<EditChurchDto, Church>();

        CreateMap<ChurchAddress, Church>()
            .ForMember(church => church.Name, map =>
            map.MapFrom(edit => edit.EditChurchDto.Name))

            .ForMember(church => church.Active, map =>
            map.MapFrom(edit => edit.EditChurchDto.Active))

            .ForMember(church => church.Acronym, map =>
            map.MapFrom(edit => edit.EditChurchDto.Acronym))

            .ForMember(church => church.RegisterDate, map =>
            map.MapFrom(edit => edit.EditChurchDto.RegisterDate))

            .ForMember(church => church.InaugurationDate, map =>
            map.MapFrom(edit => edit.EditChurchDto.InaugurationDate));
    }
}