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
    public bool Active { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsLowerThan(Name, 50, "Name", "Name should have at least 50 chars")
            .IsGreaterThan(Name, 5, "Name", "Name should have no more than 5 chars")
            .IsTrue(Active, "Active", "Unable to create a disabled user")
        );
    }
}
