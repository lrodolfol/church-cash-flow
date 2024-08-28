
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Security.Cryptography;
using System.Text;

namespace Registration.DomainCore.Events;
public class UserCreatedEvent : DomainBaseEvents
{
    public int Id { get; set; }
    public string EmailAddress { get; set; } = null!;
    public string Password { get; set; } = null!;

    public UserCreatedEvent(int id, string emailAddress, string passwordNotEncrypt) : base()
    {
        Id = id;
        EmailAddress = emailAddress;
        EncryptPassword(passwordNotEncrypt);
    }
    private void EncryptPassword(string passwordNotEncrypt)
    {
        byte[] iv = new byte[16];

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("KEYUSERCREATED"));
            aes.IV = iv;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(passwordNotEncrypt);
                    }
                }
                Password = Convert.ToBase64String(ms.ToArray());
            }
        }
    }
}
