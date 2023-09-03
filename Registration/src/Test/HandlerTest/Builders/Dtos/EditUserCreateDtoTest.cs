using HandlersTest.Builders.Entities;
using Registration.Mapper.DTOs.Registration.User;
using Registration.Mapper.DTOs.Registration.UserLogin;

namespace HandlersTest.Builders.Dtos;

public class EditUserCreateDtoTest
{
    public static EditUserCreateDto ValidObjectOne() =>
            new EditUserCreateDto()
            {
                Name = UserTest.ValidObjectOne().Name,
                PasswordHash = "passwordOne",
                ChurchId = ChurchTest.ValidObjectOne().Id,
                RoleIds = new HashSet<int>(RoleTest.ValidSomeIdObject())
            };

    public static EditUserCreateDto ValidObjectTwo() =>
        new EditUserCreateDto()
        {
            Name = UserTest.ValidObjectTwo().Name,
            PasswordHash = "passwordOne",
            ChurchId = ChurchTest.ValidObjectTwo().Id,
            RoleIds = new HashSet<int>(RoleTest.ValidSomeIdObject())
        };

    public static EditUserCreateDto ValidObjectThree() =>
        new EditUserCreateDto()
        {
            Name = UserTest.ValidObjectThree().Name,
            PasswordHash = "passwordOne",
            ChurchId = ChurchTest.ValidObjectThree().Id,
            RoleIds = new HashSet<int>(RoleTest.ValidSomeIdObject())
        };

}