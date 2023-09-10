using HandlersTest.Builders.Entities;
using Registration.Mapper.DTOs.Registration.Member;

namespace HandlersTest.Builders.Dtos;

public class EditMemberDtoTest
{
    public static EditMemberDto ValidObjectOne() =>
        new EditMemberDto()
        {
            Id = 1,
            Name = "Rodolfo de Jesus",
            DateBirth = DateTime.Now.AddYears(28),
            DateBaptism = DateTime.Now.AddYears(-1),
            ChurchId = ChurchTest.ValidObjectOne().Id,
            DateRegister = DateTime.Now,
            PostIds = PostTest.GetIds()
        };

    public static EditMemberDto ValidObjectTwo() =>
    new EditMemberDto()
    {
        Id = 2,
        Name = "Kelly Cristina Martins",
        DateBirth = DateTime.Now.AddYears(30),
        DateBaptism = DateTime.Now.AddYears(-2),
        ChurchId = ChurchTest.ValidObjectOne().Id,
        DateRegister = DateTime.Now,
        PostIds = PostTest.GetIds()
    };

    public static EditMemberDto InvalidObjectOne() =>
    new EditMemberDto()
    {
        Id = 3,
        Name = "Gustavo de Jesus",
        DateBirth = DateTime.Now.AddYears(19),
        DateBaptism = DateTime.Now.AddMonths(-5),
        ChurchId = ChurchTest.ValidObjectTwo().Id,
        DateRegister = DateTime.Now.AddDays(+5),
        PostIds = PostTest.GetIds()
    };
}