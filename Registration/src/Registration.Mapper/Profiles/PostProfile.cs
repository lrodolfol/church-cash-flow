using AutoMapper;
using CRegistration.Mapper.DTOs.Post;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Post;

namespace ChurchCashFlow.Profiles;
public class PostProfile : Profile
{
	public PostProfile()
	{
		CreateMap<Post, ReadPostDto>();
        CreateMap<EditPostDto, Post>();
    }
}