using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Registration.DomainBase.Entities.Registrations.Nosql;
public class Church : EntitieNoSql
{
    
    public string? Name { get;  set; }
    public string? Acronym { get;  set; }


    public void UpdateChanges(Church church)
    {
        Name = church.Name;
        Acronym = church.Acronym;
    }
}
