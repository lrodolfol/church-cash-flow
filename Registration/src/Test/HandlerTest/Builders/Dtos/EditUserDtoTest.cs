using HandlersTest.Builders.Entities;
using Registration.Mapper.DTOs.Registration.User;

namespace HandlersTest.Builders.Dtos;

public class EditUserDtoTest
{
    public static EditUserDto ValidObjectOne() =>
        new EditUserDto()
        {
            Id = 1,
            Name = UserTest.ValidObjectOne().Name,
            PasswordHash = "passwordOne",
            ChurchId = ChurchTest.ValidObjectOne().Id,
            RoleIds = new HashSet<int>(RoleTest.ValidSomeIdObject())
        };

    public static EditUserDto ValidObjectTwo() =>
        new EditUserDto()
        {
            Id= 2,
            Name = UserTest.ValidObjectTwo().Name,
            PasswordHash = "passwordOne",
            ChurchId = ChurchTest.ValidObjectTwo().Id,
            RoleIds = new HashSet<int>(RoleTest.ValidSomeIdObject())
        };

}