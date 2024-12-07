using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Registration.DomainBase.Entities.Registrations.Bible;
public class BibleBook
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string _Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int Number { get; set; }
    public List<Chapter> Chapters { get; set; } = null!;
}
