using AutoMapper;

namespace Registration.UnitTest.Shared.Builders.Mappers;

public class MemberPostMapperBuilder : MapperTestDto
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
