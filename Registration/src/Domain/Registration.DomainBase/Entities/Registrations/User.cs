using SecureIdentity.Password;

namespace Registration.DomainBase.Entities.Registrations;
public class User : Entitie
{
    public string Code { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;
    public int ChurchId { get; private set; }
    public int RoleId { get; private set; }
    public Church? Church { get; private set; }
    public Role? Role { get; private set; }

    public User(int id, string name, int churchId, int roleId)
    {
        Id = id;
        ChurchId = churchId;
        RoleId = roleId;
        Name = name;
    }

    public User()
    {
    }

    public void UpdateChanges(User editUser)
    {
        Name = editUser.Name;
        Active = editUser.Active;
        RoleId = editUser.RoleId;
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
}
