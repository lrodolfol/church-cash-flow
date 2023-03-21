using AutoMapper;
using ChurchCashFlow.Data.ViewModels.Dtos.User;
using ChurchCashFlow.Handlers;
using ChurchCashFlow.Profiles;
using DataModelChurchCashFlow.Context.Interface;
using RegistrationTest.ContextFake;

namespace RegistrationTest;
public class TestRegistrationUser
{
    private readonly IUserContext _fakeContext = new UserContextFake();
    private IMapper _mapper;
    private readonly UserHandler _handler;

    public TestRegistrationUser()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new UsersProfile());
        });

        _mapper = confMapper.CreateMapper();

        _handler = new UserHandler(_fakeContext, _mapper);
    }

    [Fact]
    [Trait("XUnit","Add new User")]
    public void ShouldAddNewUserNormally()
    {
        var editUserDto = new EditUserDto
        {
            Id = UserContextFake.Users.Count() + 1,
            Active = true,
            ChurchId = 1,
            Name = "Kelvin Freitas",
            PassWord = "ABCDEFGH",
            RoleId = 1
        };

        var resultViewModel = _handler.Create(editUserDto);

        var lastUser = _fakeContext.GetAll().OrderByDescending(x => x.Id).First();

        Assert.Equal(editUserDto.Name, lastUser.Name);
    }

    [Fact]
    [Trait("Xunit", "Try add new user with a wrong name")]
    public void CannotAddNewUserWithNameLessThreeCharacters()
    {
        var editUserDto = new EditUserDto
        {
            Id = UserContextFake.Users.Count() + 1,
            Active = true,
            ChurchId = 1,
            Name = "Li",
            PassWord = "ABCDEFGH",
            RoleId = 1
        };

        var resultViewModel = _handler.Create(editUserDto);

        //there must be an error
        Assert.Equal(resultViewModel.Result.Errors.Count(), 1);
    }

    [Fact]
    [Trait("Xunit", "Try add new user with a wrong name")]
    public void CannotAddNewUserWithNameGreaterThanFiftyCharacters()
    {
        var editUserDto = new EditUserDto
        {
            Id = UserContextFake.Users.Count() + 1,
            Active = true,
            ChurchId = 1,
            Name = "UmNomeQualquerQueTenhaUmaQuantidadeDeCaracteresSuperiorA50",
            PassWord = "ABCDEFGH",
            RoleId = 1
        };

        var resultViewModel = _handler.Create(editUserDto);

        //there must be an error
        Assert.Equal(resultViewModel.Result.Errors.Count(), 1);
    }

    [Fact]
    [Trait("Xunit", "Try add new user with status disabled")]
    public void CannotAddNewDisabledUser()
    {
        var editUserDto = new EditUserDto
        {
            Id = UserContextFake.Users.Count() + 1,
            Active = false,
            ChurchId = 1,
            Name = "Fernanda",
            PassWord = "ABCDEFGH",
            RoleId = 1
        };

        var resultViewModel = _handler.Create(editUserDto);

        //there must be an error
        Assert.Equal(resultViewModel.Result.Errors.Count(), 1);
    }

    [Fact]
    [Trait("Xunit", "Try add new user with empty password")]
    public void CannotAddNewWithOutPassWord()
    {
        var editUserDto = new EditUserDto
        {
            Id = UserContextFake.Users.Count() + 1,
            Active = true,
            ChurchId = 1,
            Name = "Fernanda",
            PassWord = "",
            RoleId = 1
        };

        var resultViewModel = _handler.Create(editUserDto);

        //there must be an error
        Assert.Equal(resultViewModel.Result.Errors.Count(), 1);
    }

    [Fact]
    [Trait("Xunit", "Update User")]
    public void ShouldUpdateUserNormally()
    {
        var Name = "Rodolfo Jesus";
        var newName = "Gabriela Cruz";

        var user = UserContextFake.Users.Find(x => x.Name == Name);
        var editUserDto = new EditUserDto { Name = newName, PassWord = "ABC456" };
        var resultViewModel = _handler.Update(editUserDto, user.Id);

        Assert.Equal(resultViewModel.Result.Data.Name, newName);
    }
}