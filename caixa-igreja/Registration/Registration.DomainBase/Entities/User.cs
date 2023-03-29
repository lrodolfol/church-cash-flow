using SecureIdentity.Password;

namespace Registration.DomainBase.Entities;
public class User : Entitie
{
    public string Code { get; private set; }
    public string Name { get; private set; }
    public string PassWordHash { get; private set; }
    public string PassWord { get; private set; }
    public int ChurchId { get; private set; }
    public int RoleId { get; private set; }
    public Church Church { get; private set; }
    public Role Role { get; private set; }

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
        PassWord = editUser.PassWord;
        Active = editUser.Active;
        RoleId = editUser.RoleId;
        ChurchId = editUser.ChurchId;

        GeneratePassWordHash(editUser.PassWord);
    }

    public void GeneratePassWordHash(string strPassWord)
    {
        PassWordHash = PasswordHasher.Hash(strPassWord);
    }

    public void GenerateCode()
    {
        var code = Guid.NewGuid().ToString().ToUpper();
        Code = code.Substring(0, 6);
    }
}
