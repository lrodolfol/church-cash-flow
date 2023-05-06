using System.ComponentModel.DataAnnotations;

namespace Registration.DomainBase.Entities;
public class UserLogin
{    
    public string? Code { get; set; }
    public string? PassWord { get; set; }
}