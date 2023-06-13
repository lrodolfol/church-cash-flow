namespace Registration.DomainBase.Entities.Registrations;
public class MeetingKind : Entitie
{
    public string? Name { get; private set; }
    public string? Description { get; private set; }
    public List<Offering>? Offerings { get; private set; }

    public MeetingKind(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public MeetingKind()
    {
    }
}