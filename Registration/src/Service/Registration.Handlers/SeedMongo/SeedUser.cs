using Registration.DomainCore.ContextAbstraction;

namespace Registration.Handlers.SeedMongo;
public class SeedUser : ISeedNoSql
{
    string ISeedNoSql.Name
    {
        get
        {
            return "User";
        }
        set { }
    }

    public void Seed()
    {
        throw new NotImplementedException();
    }
}
