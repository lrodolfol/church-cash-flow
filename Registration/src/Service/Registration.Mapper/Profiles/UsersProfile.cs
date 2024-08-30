using AutoMapper;
using Registration.DomainBase.Aggregate;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.User;
using Registration.Mapper.DTOs.Registration.UserLogin;

namespace Registration.Mapper.Profiles;
public class UsersProfile : Profile
{
    public UsersProfile()
    {
        CreateMap<ReadUserDto, User>();
        CreateMap<User, ReadUserDto>()
            .ForMember(dest => dest.Church, map =>
                map.MapFrom(src => src.Church!.Name)
             )
            .ForMember(dest => dest.UserRoles, map =>
                map.MapFrom(src => src.UserRoles.Select(x => x.Role).Select(r => r.Name))
            ).ForMember(dest => dest.Email, map =>
                map.MapFrom(src => src.Email.Address)
                );

        CreateMap<EditUserDto, User>();
        CreateMap<User, EditUserDto>();
        CreateMap<EditUserDto, UserLogin>();
        CreateMap<User, User>()
            .ForMember(u => u.Id, opt => opt.Ignore())
            .ForMember(u => u.Church, opt => opt.Ignore())
            //.ForMember(u => u.Role, opt => opt.Ignore())
            .ForMember(u => u.Code, opt => opt.Ignore());
        CreateMap<EditUserCreateDto, User>()
            .ForMember(dest => dest.Email, map =>
                map.MapFrom(src => new Email(src.Email))
                );
    }
}
