namespace Registration.DomainBase.Entities.Registrations;
public class Entitie
{
    public int Id { get; protected set; }
    public bool? Active { get; protected set; }

    public void Activate(bool active)
    {
        Active = active;
    }

    public string CreateGuid(int lenght) => Guid.NewGuid().ToString().ToUpper().Substring(0, lenght);
}