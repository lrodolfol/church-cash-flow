using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Post;

namespace ChurchCashFlow.Profiles;
public class PostProfile : Profile
{
	public PostProfile()
	{
		CreateMap<Post, ReadPostDto>();
        CreateMap<EditPostDto, Post>();
    }
}