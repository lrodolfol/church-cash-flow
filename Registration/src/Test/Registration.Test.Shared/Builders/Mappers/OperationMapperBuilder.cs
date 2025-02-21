using AutoMapper;
using Registration.Mapper.Profiles;

namespace Registration.UnitTest.Shared.Builders.Mappers;

public class OperationMapperBuilder : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new MonthWorkProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}
