using AutoMapper;
using Moq;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.Member;
using Registration.Repository;
using Registration.UnitTest.Test.Builders.Models;
using Registration.UnitTest.Test.Builders.Services;

namespace Registration.UnitTest.Test;

[Collection(nameof(MemberBuilders))]
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

        MemberHandler hand = new(repository,
            mapper,
            _viewModel,
            new OperationsBuilder().GetHandlerMock().Object,            
            new PostBuilders().GetHandlerMock().Object,
            new ChurchBuilders().GetMockHandler().Object,
            _fixture.GetMemberBridgeHandlerMock().Object,
            _mockLogger.Object,
            new CloudAbstractionBuilders().GetImageStoreMock().Object,
            new MemoryCashBuilders().GetMock().Object
        );

        CViewModel handResult = await hand.Create(churchAddress);

        Assert.NotNull(handResult);
        Assert.NotNull(handResult.Data);
        Assert.True(handResult.Errors.Count == 0);
    }

    [Fact(DisplayName = nameof(Delete))]
    [Trait("Domain", "Member - delete")]
    public async Task Delete()
    {
        Member member = _fixture.GetValidEntitie();
        EditMemberDto churchAddress = _fixture.GetValidEditDto();

        DataContext context = _fixture.GetContext();
        await context.Churches.AddAsync(member.Church!);
        await context.Members.AddAsync(member);
        await context.SaveChangesAsync();

        IMemberRepository repository = _fixture.GetRepository();

        var memberBridgMock = _fixture.GetMemberBridgeHandlerMock();
        var cacheMemoryMock = new MemoryCashBuilders().GetMock();

        var hand = new MemberHandler(repository,
            _fixture.GetMapper(),
            _viewModel,
            new OperationsBuilder().GetHandlerMock().Object,
            new PostBuilders().GetHandlerMock().Object,
            new ChurchBuilders().GetMockHandler().Object,
            memberBridgMock.Object,
            _mockLogger.Object,
            new CloudAbstractionBuilders().GetImageStoreMock().Object,
            cacheMemoryMock.Object
        );

        CViewModel handResult = await hand.Delete(member.Id);

        memberBridgMock.Verify(x => x.DeleteMemberInByMemberAsync(member.Id), Times.Once());
        memberBridgMock.Verify(x => x.DeleteMemberOutByMemberAsync(member.Id), Times.Once());
        cacheMemoryMock.Verify(x => x.Remove(member.Id), Times.AtMost(3));

        Assert.True(!member.Active);
        Assert.True(handResult.Errors.Count == 0);
    }

    public void Dispose() =>
        _fixture.ClearContext();
}
