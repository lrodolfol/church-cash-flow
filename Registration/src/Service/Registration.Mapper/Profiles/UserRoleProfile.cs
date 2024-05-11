using Registration.Mapper.DTOs.Registration.UserRole;
using AutoMapper;
using Registration.DomainBase.Entities.Registrations.sql;

namespace Registration.Mapper.Profiles;

public class UserRoleProfile : Profile
{
    public UserRoleProfile() 
    {
        CreateMap<EditUserRoleDto, UserRole>();
    }
}