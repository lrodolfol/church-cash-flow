using AutoMapper;
using Registration.Mapper.Profiles;
using Registration.UnitTest.Shared.Builders.Mappers;

namespace Registration.Test.Shared.Builders.Mappers;
public class AddressMappersBuilder : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new AddressProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}
