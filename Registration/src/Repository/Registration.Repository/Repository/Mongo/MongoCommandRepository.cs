using MongoDB.Driver;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Repository.Mongo;
public class MongoCommandRepository<T>
{
    private readonly IMongoDatabase _dataBase;
    private readonly IMongoCollection<T> _collection;
    protected string _collectionName { get; set; }

    public MongoCommandRepository(IMongoDatabase context, string collectionName)
    {
        _dataBase = context;
        _collectionName = collectionName;
        _collection = _dataBase.GetCollection<T>(_collectionName);
    }
    
    public async Task Create(T user)
    {
        await _collection.InsertOneAsync(user);
    }
}
