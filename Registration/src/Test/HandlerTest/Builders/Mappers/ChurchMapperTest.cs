using AutoMapper;
using ChurchCashFlow.Profiles;

namespace HandlersTest.Builders.Mappers;

public class ChurchMapperTest
{
    public static IMapper _mapper = null!;

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