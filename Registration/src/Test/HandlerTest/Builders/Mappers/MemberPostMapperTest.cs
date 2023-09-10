using AutoMapper;

namespace HandlersTest.Builders.Mappers;

public class MemberPostMapperTest : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}
