using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Data.ViewModels.Dtos.User;
using ChurchCashFlow.Handlers;
using ChurchCashFlow.Profiles;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Entities;
using RegistrationTest.ContextFake;

namespace RegistrationTest;
public class RegistrationUser
{
    private readonly IUserContext _fakeContext = new UserContextFake();
    private IMapper _mapper;

    public RegistrationUser()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new UsersProfile());
        });

        _mapper = confMapper.CreateMapper();
    }

    [Fact]
    [Trait("XUnit","Add new User")]
    public void ShouldTurnBackAllUsersWithoutErros()
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

        var userHandler = new UserHandler(_fakeContext, _mapper);

        var resultViewModel = userHandler.Create(editUserDto);

        var lastUser = _fakeContext.GetAll().OrderByDescending(x => x.Id).First();

        //the last name of the Users list should be the this User.Name.
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

        var userHandler = new UserHandler(_fakeContext, _mapper);

        var resultViewModel = userHandler.Create(editUserDto);

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

        var userHandler = new UserHandler(_fakeContext, _mapper);

        var resultViewModel = userHandler.Create(editUserDto);

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

        var userHandler = new UserHandler(_fakeContext, _mapper);

        var resultViewModel = userHandler.Create(editUserDto);

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

        var userHandler = new UserHandler(_fakeContext, _mapper);

        var resultViewModel = userHandler.Create(editUserDto);

        //there must be an error
        Assert.Equal(resultViewModel.Result.Errors.Count(), 1);
    }
}