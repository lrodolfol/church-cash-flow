using AutoMapper;
using Registration.Mapper.Profiles;

namespace HandlersTest.Builders.Mappers;

public class MemberMapperTest : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new MemberProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}