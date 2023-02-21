﻿using AutoMapper;
using ChurchCashFlow.Models;
using ChurchCashFlow.ViewModels.Dtos.User;

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
    }
}
