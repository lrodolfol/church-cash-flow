using ConsumerChurchMonthWork.Entitie;
using ConsumerChurchMonthWork.Models;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;

namespace ConsumerChurchMonthWork.Services;
public class SendEmailNewUser
{
    public async Task SendEmailAsync(UserCreatedMessageDto userCreated)
    {
        var pass = DescriptyPassword(userCreated.Password);
        var body = @$"Ola! seu cadastro foi realizado com sucesso na plafaforma churchManager!
                    
                    Guarde sua senha para acessar a aplicação: 
                    senha: {pass}";
        var message = PrepareteMessage(userCreated.EmailAddress, "Cadastro - ChurchManager", body);

        SendEmailBySmtp(message);
    }
    private string DescriptyPassword(string password)
    {
        byte[] ivv = new byte[16];
        byte[] buffer = Convert.FromBase64String(password);

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("KEYUSERCREATED"));
            aes.IV = ivv;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using MemoryStream memoryStream = new(buffer);
            using CryptoStream cryptoStream = new((Stream)memoryStream, decryptor, CryptoStreamMode.Read);
            using (StreamReader streamReader = new((Stream)cryptoStream))
            {
                var pass = streamReader.ReadToEnd();
                return pass;
            }
        }
    }

    private MailMessage PrepareteMessage(string emailTo, string subject, string body)
    {
        var mail = new MailMessage();
        mail.From = new MailAddress(Environment.GetEnvironmentVariable("CHURCHMANAGEREMAIL"));
        mail.To.Add(emailTo);
        mail.Subject = subject;
        mail.Body = body;
        mail.IsBodyHtml = true;

        return mail;
    }

    private void SendEmailBySmtp(MailMessage message)
    {
        SmtpClient smtpClient = new SmtpClient("smtp.office365.com");
        smtpClient.Host = "smtp.office365.com";
        smtpClient.Port = 587;
        smtpClient.EnableSsl = true;
        smtpClient.Timeout = 50000;
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential(Environment.GetEnvironmentVariable("CHURCHMANAGEREMAIL"), Environment.GetEnvironmentVariable("PASSEMAIL"));
        smtpClient.Send(message);
        smtpClient.Dispose();
    }
}
