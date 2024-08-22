using AutoMapper;
using Registration.Mapper.Profiles;

namespace HandlersTest.Builders.Mappers;

public class OfferingMapperTest : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new OfferingProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}