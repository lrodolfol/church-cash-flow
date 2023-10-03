using AutoMapper;
using ChurchCashFlow.Profiles;

namespace HandlersTest.Builders.Mappers;

public class OutFlowKindMapperTest : MapperTestDto
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