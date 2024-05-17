namespace Registration.DomainCore.ContextAbstraction;
public interface ISeedNoSql
{
    public void Seed();
    string Name { get; set; }
}
