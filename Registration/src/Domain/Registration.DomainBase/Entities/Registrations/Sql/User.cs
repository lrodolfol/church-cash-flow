using SecureIdentity.Password;

namespace Registration.DomainBase.Entities.Registrations.sql;
public class User : Entitie
{
    public string Code { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;
    public int ChurchId { get; private set; }
    public Church? Church { get; private set; }

    public List<UserRole>? UserRoles { get; set; }

    public User(int id, string name, int churchId)
    {
        Id = id;
        ChurchId = churchId;
        Name = name;
    }

    public void UpdateChanges(User editUser)
    {
        Name = editUser.Name;
        Active = editUser.Active;
        ChurchId = editUser.ChurchId;

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


    public static implicit operator Registration.DomainBase.Entities.Registrations.NoSql.User(
    Registration.DomainBase.Entities.Registrations.sql.User userSql)
    {

        var userNoSql = new Registration.DomainBase.Entities.Registrations.NoSql.User()
        {
            Name = userSql.Name,
            Code = userSql.Code,
            Role = "Admin"
        };

        return userNoSql;
    }
}
