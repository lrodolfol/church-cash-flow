using AutoMapper;
using Registration.Mapper.Profiles;

namespace HandlersTest.Builders.Mappers;

public class UserMapperTest
{
    public static IMapper _mapper = null!;

    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new UsersProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}