using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Abstractions;
using Registration.Mapper.DTOs.Registration.Member;
using Registration.Mapper.Profiles;
using Registration.Repository;
using Registration.Repository.Repository.Registration;
using Registration.Test.Shared.Builders.Mappers;
using Registration.UnitTest.Shared.Builders.Mappers;

namespace Registration.UnitTest.Test.Builders.Models;
public class MemberBuilders : BaseBuilder
{
    public MemberBuilders() : base()
    {
        
    }
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
        Church church = new(
            GetRandomInt(), GetValidPersonFullNameName(),
            GetValidBeforeDate(), GetValidBeforeDate(),
            GetRandomInt(), GetValidCode()
            );
        
        var member = new Member(GetRandomInt(),
            GetValidPersonFullNameName(),
            GetValidBeforeDate(),
            GetValidBeforeDate(),
            GetRandomInt(),
            GetValidCode(),
            GetValidNearDate()
            );
        member.Activate(true);
        member.AddChurch(church);

        return member;
    }
    public EditMemberDto GetValidEditDto()
    {
        var mapper = GetMapper();
        Member entitie = GetValidEntitie();
        var editEntitie = mapper.Map<EditMemberDto>(entitie);
        editEntitie.PostIds = new HashSet<int>(new int[] {1,2,3});

        return editEntitie;
    }

    public IMapper GetMapper() =>
        BaseModelMapperBuilder<Member>.Mapper();

    public Mock<IMemberBridgesHandler> GetMemberBridgeHandlerMock()
    {
        Mock<IMemberBridgesHandler> mock = new Mock<IMemberBridgesHandler>();

        mock.Setup(x => x.CreateMemberPostAsync(It.IsAny<int>(), It.IsAny<int[]>()))
            .Returns(Task.FromResult(true));
        mock.Setup(x => x.DeletePostByMemberAsync(It.IsAny<int>()))
            .Returns(Task.FromResult(true));
        mock.Setup(x => x.DeleteMemberOutByMemberAsync(It.IsAny<int>()))
            .Returns(Task.FromResult(true));
        mock.Setup(x => x.DeleteMemberInByMemberAsync(It.IsAny<int>()))
        .Returns(Task.FromResult(true));

        return mock;
    }
}
[CollectionDefinition(nameof(MemberBuilders))]
public class MemberBuilderFixtureCollection : ICollectionFixture<MemberBuilders> { }