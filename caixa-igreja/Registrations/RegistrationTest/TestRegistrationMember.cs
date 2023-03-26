using AutoMapper;
using ChurchCashFlow.Data.Context;
using ChurchCashFlow.Data.ViewModels.Dtos.Member;
using ChurchCashFlow.Handlers;
using ChurchCashFlow.Profiles;
using DataModelChurchCashFlow.Context.Interface;
using RegistrationTest.ContextFake;

namespace RegistrationTest;
public class TestRegistrationMember
{
    private readonly IMemberContext _fakeContext = new MemberContextFake();
    private readonly IChurchContext _fakeContextChurch = new ChurchContextFake();
    private readonly IPostContext _fakeContextPost = new PostContextFake();
    private IMapper _mapper;
    private readonly MemberHandler _handler;

    public TestRegistrationMember()
	{
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new MemberProfile());
        });

        _mapper = confMapper.CreateMapper();

        _handler = new MemberHandler(_fakeContext, _fakeContextChurch, _fakeContextPost,  _mapper);
    }

    [Fact]
    [Trait("Xunit", "Add new Member")]
    public void ShoudAddNewMemberNormaly()
    {
        var editMemberDto = new EditMemberDto 
        { 
            Id = MemberContextFake.Members.Count() + 1, 
            Name = "Alberto Siqueira", 
            DateBirth= DateTime.Now, 
            ChurchId = 1, PostId = 2 
        };
        var resultViewModel = _handler.Create(editMemberDto);

        Assert.NotNull(resultViewModel.Result.Data);
    }

    [Fact]
    [Trait("Xunit", "Get member by code")]
    public void ShoudReturnTheMemberByCode()
    {
        var member = MemberContextFake.Members.First();

        var resultViewModel = _handler.GetByCode(member.Code);

        Assert.Equal(member.Name, resultViewModel.Result.Data.Name);
    }
}
