using Flunt.Notifications;
using Flunt.Validations;
using Registration.Mapper.DTOs;

namespace Registration.Mapper.DTOs.Registration.Post;
public class EditPostDto : ModelDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsLowerThan(Name, 50, "Name", "Name should have more than 50 chars")
            .IsGreaterThan(Name, 2, "Name", "Name should have at least 3 chars")
            .IsLowerThan(Description, 100, "Description", "Description should have no more than 100 chars")
            .IsGreaterThan(Description, 10, "Description", "Description should have at least 10 chars")
            );
    }
}