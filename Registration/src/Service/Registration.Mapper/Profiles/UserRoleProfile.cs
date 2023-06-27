using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.UserRole;
using AutoMapper;

namespace Registration.Mapper.Profiles;

public class UserRoleProfile : Profile
{
    public UserRoleProfile() 
    {
        CreateMap<EditUserRoleDto, UserRole>();
    }
}