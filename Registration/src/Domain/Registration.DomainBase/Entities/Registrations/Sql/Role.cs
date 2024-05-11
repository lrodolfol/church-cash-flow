namespace Registration.DomainBase.Entities.Registrations.sql;
public class Role : Entitie
{
    public string? Name { get; set; }
    public int RoleId { get; set; }

    public List<UserRole>? UserRoles { get; set; }

    public Role(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
