using AutoMapper;
using ChurchCashFlow.Profiles;

namespace HandlersTest.Builders.Mappers;

public class PostMapperTest
{
    public static IMapper _mapper = null!;

    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new PostProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}