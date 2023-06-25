using Flunt.Notifications;
using Flunt.Validations;
using Registration.DomainBase.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Registration.Mapper.DTOs.Registration.UserLogin;

public class EditUserCreateDto : ModelDto
{
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
    public string Name { get; set; } = string.Empty;
    [Required]
    [StringLength(8, MinimumLength = 6, ErrorMessage = "Name must be between 6 and 8 characters")]
    public string PasswordHash { get; set; } = string.Empty;
    public int ChurchId { get; set; }
    public HashSet<int> RoleIds { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsLowerThan(Name, 50, "Name", "Name should have no more than 50 chars")
            .IsGreaterThan(Name, 2, "Name", "Name should have at least 3 chars")
            .IsTrue(Active, "Active", "Unable to create a disabled user")
            .IsNotNullOrEmpty(PasswordHash, "PassWord", "The password can not be empty")
            .IsNotNull(RoleIds, "RolesId", "User must have a role")
        );
    }
}