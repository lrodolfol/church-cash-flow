using System.ComponentModel.DataAnnotations;

namespace Registration.Mapper.DTOs.UserLogin;
public class EditUserLogin
{
    [Required]
    public string Code { get; set; }
    [Required]
    public string PassWord { get; set; }
}