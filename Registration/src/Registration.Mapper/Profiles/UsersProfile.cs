using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.User;
using Registration.Mapper.DTOs.UserLogin;

namespace Registration.Mapper.Profiles;
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
        CreateMap<User, EditUserDto>();
        CreateMap<EditUserDto, UserLogin>();
        CreateMap<User, User>()
            .ForMember(u => u.Id, opt => opt.Ignore())
            .ForMember(u => u.Church, opt => opt.Ignore())
            .ForMember(u => u.Role, opt => opt.Ignore())
            .ForMember(u => u.Code, opt => opt.Ignore());
        CreateMap<EditUserCreateDto, User>();
    }
}
