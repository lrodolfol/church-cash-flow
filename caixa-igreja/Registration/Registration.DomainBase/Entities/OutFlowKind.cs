namespace Registration.DomainBase.Entities;
public class OutFlowKind : Entitie
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public List<OutFlow> OutFlows { get; private set; }

    public OutFlowKind(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public OutFlowKind()
    {
    }
}