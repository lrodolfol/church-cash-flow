using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Registration.DomainBase.Entities.Registrations;
public class EntitieNoSql
{
    [BsonId] //para designar essa propriedade como a chave primária do documento.
    [BsonRepresentation(BsonType.ObjectId)] //para permitir a passagem do parâmetro como tipo string, em vez de uma estrutura ObjectId. O Mongo processa a conversão de string para ObjectId.
    public string Id { get; protected set; }

}