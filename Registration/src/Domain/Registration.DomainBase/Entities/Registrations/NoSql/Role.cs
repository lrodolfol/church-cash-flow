namespace Registration.DomainBase.Entities.Registrations.NoSql;
public struct Role
{
    public string? Name { get; set; }

    public Role(string name) => Name = name;    
}
