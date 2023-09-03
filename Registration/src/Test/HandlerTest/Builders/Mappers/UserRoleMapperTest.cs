using AutoMapper;
using Registration.Mapper.Profiles;

namespace HandlersTest.Builders.Mappers;

public class UserRoleMapperTest
{
    public static IMapper _mapper = null!;

    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new UserRoleProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}