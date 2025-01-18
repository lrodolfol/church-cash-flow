using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.Mapper.DTOs.Registration.Member;
using Registration.Mapper.Profiles;
using Registration.Repository;
using Registration.Repository.Repository.Registration;
using Registration.Test.Shared.Builders.Mappers;
using Registration.UnitTest.Shared.Builders.Mappers;

namespace Registration.UnitTest.Test.Builders;
public class MemberBuilders : BaseBuilder
{
    internal void Initialize()
    {
        BuilderDataContext();
        BuilderRespository();
        BuilderMapper();

        ServiceProvider = ServiceCollection.BuildServiceProvider();
    }
    private ServiceCollection BuilderRespository()
    {
        ServiceCollection.AddScoped<IMemberRepository, MemberRepository>();

        return ServiceCollection;
    }
    private ServiceCollection BuilderMapper()
    {
        ServiceCollection.AddSingleton(MemberMapperBuilder.Mapper());
        ServiceCollection.AddAutoMapper(typeof(MemberProfile));

        return ServiceCollection;
    }
    public IMemberRepository GetRepository()
    {
        var context = ServiceProvider.GetRequiredService<DataContext>();
        context.Database.EnsureCreated();

        IMemberRepository respository = ServiceProvider.GetRequiredService<IMemberRepository>();
        return respository;
    }

    public Member GetValidEntitie()
    {
        return new Member(GetRandomInt(),
            GetValidPersonFullNameName(),
            GetValidBeforeDate(),
            GetValidBeforeDate(),
            GetRandomInt(),
            GetValidCode(),
            GetValidNearDate()
            );
    }
    public EditMemberDto GetValidEditDto() =>
        GetMapper().Map<EditMemberDto>(GetValidEntitie());

    public IMapper GetMapper() =>
        BaseModelMapperBuilder<Member>.Mapper();
}
