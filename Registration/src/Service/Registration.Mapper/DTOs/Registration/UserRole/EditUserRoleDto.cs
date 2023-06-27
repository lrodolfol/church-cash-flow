using Flunt.Notifications;
using Flunt.Validations;
using System.Diagnostics.Contracts;

namespace Registration.Mapper.DTOs.Registration.UserRole;

public class EditUserRoleDto : ModelDto
{
    public int RoleId { get; set; }
    public int UserId { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsGreaterThan(RoleId, 0, "Role is invalid")
            .IsGreaterThan(UserId, 0, "User is invalid")
            );
    }

}