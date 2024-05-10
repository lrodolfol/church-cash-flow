using MongoDB.Driver;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Repository.Mongo;
public class MongoQueryRepository<T> where T : Entitie
{
    protected readonly IMongoDatabase _context;
    protected string _collectionName { get; set; }

    protected MongoQueryRepository(IMongoDatabase context)
    {
        _context = context;
    }
}
