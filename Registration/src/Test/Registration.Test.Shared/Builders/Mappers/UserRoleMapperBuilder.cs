using AutoMapper;
using Registration.Mapper.Profiles;

namespace Registration.UnitTest.Shared.Builders.Mappers;

public class UserRoleMapperBuilder : MapperTestDto
{
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