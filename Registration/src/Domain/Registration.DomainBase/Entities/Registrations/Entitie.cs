namespace Registration.DomainBase.Entities.Registrations;
public class Entitie
{
    public int Id { get; protected set; }
    public bool Active { get; protected set; } = true;

    public void Activate(bool active)
    {
        Active = active;
    }

}