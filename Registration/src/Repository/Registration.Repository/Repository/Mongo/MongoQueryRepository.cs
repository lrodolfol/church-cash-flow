using MongoDB.Driver;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Repository.Mongo;
public class MongoQueryRepository<T> where T : EntitieNoSql
{
    private readonly IMongoDatabase _dataBase;
    private readonly IMongoCollection<T> _collection;
    protected string _collectionName { get; set; }

    public MongoQueryRepository(IMongoDatabase context, string collectionName)
    {
        _dataBase = context;
        _collectionName = collectionName;
        _collection = _dataBase.GetCollection<T>(_collectionName);
    }

    public async Task Get(string id)
    {
        T model = await _collection
            .Find(x => x.Id == id).FirstOrDefaultAsync();

        await Console.Out.WriteLineAsync("dd");
    }

    public async Task Create(T user)
    {
        await _collection.InsertOneAsync(user);
    }
}
