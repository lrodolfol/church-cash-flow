using AutoMapper;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.ChurchAddress;
using Registration.Mapper.DTOs.Registration.Member;
using Registration.UnitTest.Test.Builders;

namespace Registration.UnitTest.Test;
public class MemberTest : BaseUnitTest, IDisposable
{
    private readonly MemberBuilders _fixture;

    public MemberTest(MemberBuilders fixture)
    {
        _fixture = fixture;
        _fixture.Initialize();
    }

    [Fact(DisplayName = nameof(Create))]
    [Trait("Domain", "Member - create")]
    public async void Create()
    {
        IMemberRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();
        EditMemberDto churchAddress = _fixture.GetValidEditDto();

        MemberHandler hand = new MemberHandler(repository, mapper, _viewModel, operationsHandler, postHandler, churchHandler, memberBridgesHandler, _mockLogger.Object, configuration, memoryCache);
        CViewModel handResult = await hand.Create(churchAddress);

        Assert.NotNull(handResult);
        Assert.NotNull(handResult.Data);
        Assert.True(handResult.Errors.Count == 0);
    }

    public void Dispose() =>
        _fixture.ClearContext();
}
