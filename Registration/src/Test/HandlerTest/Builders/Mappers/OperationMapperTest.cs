using AutoMapper;
using ChurchCashFlow.Profiles;
using Registration.Mapper.Profiles;

namespace HandlersTest.Builders.Mappers;

public class OperationMapperTest : MapperTestDto
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
