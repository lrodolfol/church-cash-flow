using AutoMapper;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.Profiles;
using Registration.UnitTest.Shared.Builders.Mappers;

namespace Registration.Test.Shared.Builders.Mappers;
public class BaseModelMapperBuilder<T> : MapperTestDto where T : class
{
    public static IMapper Mapper()
    {
        var className = typeof(T).Name;

        switch (className)
        {
            case "Address":
                throw new Exception("This mapper is not used. Do you need churchAddress?");
            case "Church":
                return ChurchMapperBuilder.Mapper();
            default:
                throw new NotImplementedException();
        }


        
    }
}
