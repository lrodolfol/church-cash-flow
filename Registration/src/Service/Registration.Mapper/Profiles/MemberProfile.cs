using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Member;
using Registration.Mapper.DTOs.Registration.MemberOut;
using Registration.Mapper.DTOs.Registration.MemberPost;

namespace ChurchCashFlow.Profiles;
public class MemberProfile : Profile
{
	public MemberProfile()
	{
		CreateMap<Member, ReadMemberDto>()
			.ForMember(dto => dto.Church, map =>
				map.MapFrom(member => member.Church!.Name))
			.ForMember(dest => dest.MemberOut, map =>
				map.MapFrom(source => new ReadMemberOut()
					{ 
						MemberId = source.MembersOut!.MemberId, 
						Reason = source.MembersOut.Reason, 
						Day = source.MembersOut.Day, 
						Id = source.MembersOut.Id,
						Active = source.MembersOut.Active
					}
				))
            .ForMember(dest => dest.MemberIn, map =>
				map.MapFrom(source => new ReadMemberIn()
					{
						ChurchName = source.MemberIn!.ChurchName,
						LastPost = source.MemberIn!.LastPost,
						LetterReceiver = source.MemberIn!.LetterReceiver,	
						Id = source.MemberIn!.Id,
						Active = source.MemberIn!.Active
					}
				))
            .ForMember(dest => dest.MemberPost, map =>
			map.MapFrom(source => source.MemberPost
					.Select(x => new ReadMemberPost() 
						{ 
							Name = x.Posts!.Name!, 
							Id = x.Posts!.Id,
							Active = x.Posts!.Active
						} 
				)));

		CreateMap<EditMemberDto, Member>();
	}
}