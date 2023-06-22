namespace Registration.DomainBase.Entities.Registrations;
public class Role : Entitie
{
    public string? Name { get; set; }

    //public IList<User>? Users { get; set; }
    public IList<UserRole>? UserRoles { get; set; }

    public Role(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
