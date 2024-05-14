namespace Registration.DomainBase.Entities.Registrations.NoSql;
public struct Member
{
    public string Name { get; set; } = null!;
    public string? Photo { get; set; }
    public string? Description { get; set; }
    public DateTime DateBirth { get; set; }
    public DateTime DateRegister { get; set; }
    public DateTime DateBaptism { get; set; }
    public Church Church { get; set; } = null!;

    public Member(string name, string? photo, string? description, DateTime dateBirth, 
        DateTime dateRegister, DateTime dateBaptism, Church church)
    {
        Name = name;
        Photo = photo;
        Description = description;
        DateBirth = dateBirth;
        DateRegister = dateRegister;
        DateBaptism = dateBaptism;
        Church = church;
    }
}
