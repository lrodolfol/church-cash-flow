using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace ChurchCashFlow.Data.ViewModels.Dtos.User;

public class EditUserDto : ModelDto
{
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
    public string Name { get; set; }
    [Required]
    [StringLength(8, MinimumLength = 6, ErrorMessage = "Name must be between 6 and 8 characters")]
    public string PassWord { get; set; }
    public bool Active { get; set; } = true;
    public int ChurchId { get; set; }
    public int RoleId { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsLowerThan(Name, 50, "Name", "Name should have at least 50 chars")
            .IsGreaterThan(Name, 3, "Name", "Name should have no more than 3 chars")
            .IsTrue(Active, "Active", "Unable to create a disabled user")
            .IsNotNullOrEmpty(PassWord, "PassWord", "The password can not be empty")
        );
    }

}
