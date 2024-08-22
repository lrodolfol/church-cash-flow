using AutoMapper;
using Registration.Mapper.Profiles;

namespace HandlersTest.Builders.Mappers;

public class ChurchMapperTest : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new ChurchProfile());
            conf.AddProfile(new AddressProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}