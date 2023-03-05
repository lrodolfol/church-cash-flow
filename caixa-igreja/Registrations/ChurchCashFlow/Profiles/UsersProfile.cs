using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.User;
using DataModelChurchCashFlow.Entities;

namespace ChurchCashFlow.Profiles;
public class UsersProfile : Profile
{
    public UsersProfile()
    {
        CreateMap<ReadUserDto, User>();
        CreateMap<User, ReadUserDto>()
            .ForMember(dest => dest.Church, map =>
            map.MapFrom(src => src.Church.Name))
            .ForMember(dest => dest.Role, map =>
            map.MapFrom(src => src.Role.Name));

        CreateMap<EditUserDto, User>();
        CreateMap<User, User>()
            .ForMember(u => u.Id, opt => opt.Ignore())
            .ForMember(u => u.Church, opt => opt.Ignore())
            .ForMember(u => u.Role, opt => opt.Ignore())
            .ForMember(u => u.Code, opt => opt.Ignore());
    }
}
