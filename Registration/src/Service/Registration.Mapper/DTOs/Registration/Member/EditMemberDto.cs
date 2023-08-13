using Flunt.Notifications;
using Flunt.Validations;
using Registration.Mapper.DTOs.Registration.MemberIn;

namespace Registration.Mapper.DTOs.Registration.Member;
public class EditMemberDto : ModelDto
{
    public string? Name { get; set; }
    public string? Photo { get; set; }
    public string? Description { get; set; }
    public DateTime DateBirth { get; set; }
    public DateTime DateBaptism { get; set; }
    public DateTime DateRegister { get; set; }
    public int ChurchId { get; set; }
    public HashSet<int>? PostIds { get; set; }
    public EditMemberInDto? EditMemberInDto { get; set; }


    public void Validate()
    {
        DateTime t;
        if ( (!DateTime.TryParse(DateBirth.ToString(), out t)) || DateBirth.Year == 1)
            AddNotification("DateBirth", "The BirthDate is a invalid date");

        if (!DateTime.TryParse(DateBaptism.ToString(), out t))
            AddNotification("DateBaptism", "The BaptismDate is a invalid date");

        if ( (!DateTime.TryParse(DateRegister.ToString(), out t)) || DateRegister.Year == 1)
            AddNotification("DateBaptism", "The RegisterDate is a invalid date");

        AddNotifications(new Contract<Notification>()
            .IsLowerThan(Name, 50, "Name", "Name should have no more than 50 chars")
            .IsGreaterThan(Name, 2, "Name", "Name should have at least 3 chars")
            .IsLowerThan(Description, 100, "Name", "Description should have no more than 100 chars")
            .IsGreaterThan(ChurchId, 0, "ChurchId", "Church Id cannot empty")
            .IsGreaterThan(PostIds, 0, "PostId", "PostId Id cannot empty")
            );
    }
}