namespace Registration.DomainBase.Entities.Registrations;

public class UserRole : Entitie
{
    public int UserId { get; set; }
    public int RoleId { get; set; }

    public User? User { get; set; }
    public Role? Role { get; set; }

    public UserRole(int id, int userId, int roleId)
    {
        Id = id;
        UserId = userId;
        RoleId = roleId;
    }

    public UserRole(int userId, int roleId)
    {
        UserId = userId;
        RoleId = roleId;
    }
}