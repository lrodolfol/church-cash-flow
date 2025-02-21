using AutoMapper;
using Registration.Mapper.Profiles;

namespace Registration.UnitTest.Shared.Builders.Mappers;

public class OutFlowKindMapperBuilder : MapperTestDto
{
    public static IMapper Mapper()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new OutFlowKindProfile());
        });

        _mapper = confMapper.CreateMapper();

        return _mapper;
    }
}