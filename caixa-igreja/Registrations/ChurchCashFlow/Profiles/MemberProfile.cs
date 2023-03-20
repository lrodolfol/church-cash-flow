using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.Member;
using DataModelChurchCashFlow.Models.Entities;

namespace ChurchCashFlow.Profiles;
public class MemberProfile : Profile
{
	public MemberProfile()
	{
		CreateMap<Member, ReadMemberDto>()
			.ForMember(dto => dto.Post, map =>
			map.MapFrom(member => member.Post.Name))
			.ForMember(dto => dto.Church, map =>
			map.MapFrom(member => member.Church.Name));
		CreateMap<EditMemberDto, Member>();
	}
}