namespace DataModelChurchCashFlow.Entities;
public class Entitie
{
    public int Id { get; protected set; }
    public bool? Active { get; protected set; }

    public void Activate(bool active)
    {
        Active = active;
    }
}