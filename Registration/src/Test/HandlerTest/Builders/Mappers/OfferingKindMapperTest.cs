using AutoMapper;
using Registration.Mapper.Profiles;

namespace HandlersTest.Builders.Mappers;

public class OfferingKindMapperTest : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new OfferingKindProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}