using AutoMapper;
using ChurchCashFlow.Profiles;

namespace HandlersTest.Builders.Mappers;

public class MeetingKindMapper : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new MeetingKindProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}