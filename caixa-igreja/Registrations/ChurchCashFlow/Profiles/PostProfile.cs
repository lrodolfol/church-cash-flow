using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.Post;
using DataModelChurchCashFlow.Models.Entities;

namespace ChurchCashFlow.Profiles;
public class PostProfile : Profile
{
	public PostProfile()
	{
		CreateMap<Post, ReadPostDto>();
        CreateMap<EditPostDto, Post>();
    }
}