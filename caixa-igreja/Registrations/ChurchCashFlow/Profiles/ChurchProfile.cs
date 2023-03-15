using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using ChurchCashFlow.Data.Entities;
using DataModelChurchCashFlow.Models.Entities;

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
            map.MapFrom(edit => edit.EditChurchDto.Active));
    }
}