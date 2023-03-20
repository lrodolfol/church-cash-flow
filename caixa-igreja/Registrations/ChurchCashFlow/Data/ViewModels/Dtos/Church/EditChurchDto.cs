using ChurchCashFlow.Data.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;

namespace ChurchCashFlow.Data.ViewModels.Dtos.Church;
public class EditChurchDto : ModelDto
{
    [Required(ErrorMessage = "The name is required")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "The size must be between 5 and 50 characters")]
    public string Name { get; set; }
    public string Acronym { get; set; }
    public bool Active { get; set; }
    public EditChurchDto(string name)
    {
        Name = name;
        Active = true;
    }

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsLowerThan(Name, 50, "Name", "Name should have no more than 5 chars")
            .IsGreaterThan(Name, 5, "Name", "Name should have at least 50 chars")
            .IsTrue(Active, "Active", "Unable to create a disabled user")
            .IsLowerThan(Name, 6, "Name", "Name should have no more than 6 chars")
            .IsGreaterThan(Name, 2, "Name", "Acronym should have at least 3 chars")
        );
    }
}
