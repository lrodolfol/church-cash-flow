using Registration.DomainCore.ContextAbstraction;
using Registration.Repository.Repository.Mongo;

namespace Registration.Handlers.SeedMongo;
public class SeedUser : ISeedNoSql
{
    private readonly IUserRepository _userRepository;
    private readonly MongoCommandRepository<List<DomainBase.Entities.Registrations.NoSql.User>> _mongoCommand;

    public SeedUser(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

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
        List<Registration.DomainBase.Entities.Registrations.sql.User> listUserSql = _userRepository.GetAll()!.ToList();
        List<Registration.DomainBase.Entities.Registrations.NoSql.User> listUserNoSql = new ();

        listUserSql.ForEach(x =>
        {
            listUserNoSql.Add(x);
        });

        _mongoCommand.Create(listUserNoSql).Wait();
    }
}
