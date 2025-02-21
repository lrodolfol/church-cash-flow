using AutoMapper;
using Registration.Mapper.Profiles;

namespace Registration.UnitTest.Shared.Builders.Mappers;

public class ChurchMapperBuilder : MapperTestDto
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