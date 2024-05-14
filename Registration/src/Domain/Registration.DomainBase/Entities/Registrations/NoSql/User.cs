using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using SecureIdentity.Password;

namespace Registration.DomainBase.Entities.Registrations.NoSql;
public class User : EntitieNoSql
{
    public string Code { get;  set; } = null!;
    public string Name { get;  set; } = null!;
    public string PasswordHash { get; private set; } = string.Empty;
    public Church? Church { get; set; }
    public string? Role { get; set; }

    public User()
    {
        
    }
    public User(string id, string name, int churchId)
    {
        Id = id;
        Name = name;
    }

    public void UpdateChanges(User editUser)
    {
        Name = editUser.Name;

        GeneratePassWordHash(editUser.PasswordHash);
    }

    public void GeneratePassWordHash(string strPassWord)
    {
        PasswordHash = PasswordHasher.Hash(strPassWord);
    }

    public void GenerateCode()
    {
        var code = Guid.NewGuid().ToString().ToUpper();
        Code = code.Substring(0, 6);
    }
}
