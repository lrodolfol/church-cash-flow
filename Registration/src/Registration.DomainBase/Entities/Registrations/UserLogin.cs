using System.ComponentModel.DataAnnotations;

namespace Registration.DomainBase.Entities.Registrations;
public class UserLogin
{
    public string? Code { get; set; }
    public string? PassWord { get; set; }
}