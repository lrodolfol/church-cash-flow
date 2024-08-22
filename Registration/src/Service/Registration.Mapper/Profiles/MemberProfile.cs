using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Member;
using Registration.Mapper.DTOs.Registration.MemberIn;
using Registration.Mapper.DTOs.Registration.MemberOut;
using Registration.Mapper.DTOs.Registration.MemberPost;

namespace Registration.Mapper.Profiles;
public class MemberProfile : Profile
{
    public MemberProfile()
    {
        CreateMap<Member, ReadMemberDto>()
            .ForMember(dto => dto.Church, map =>
                map.MapFrom(member => member.Church!.Name))
            .ForMember(dest => dest.MemberOut, map =>
                map.MapFrom(source => new ReadMemberOutDto()
                {
                    MemberId = source.MemberOut!.MemberId,
                    Reason = source.MemberOut.Reason,
                    Day = source.MemberOut.Day,
                    Id = source.MemberOut.Id,
                    Active = source.MemberOut.Active
                }
                ))
            .ForMember(dest => dest.MemberIn, map =>
                map.MapFrom(source => new ReadMemberInDto()
                {
                    ChurchName = source.MemberIn!.ChurchName,
                    LastPost = source.MemberIn!.LastPost,
                    LetterReceiver = source.MemberIn!.LetterReceiver,
                    MemberId = source.MemberIn!.MemberId,
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