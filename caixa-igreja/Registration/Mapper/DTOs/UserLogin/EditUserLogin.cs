using Registration.DomainCore.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace Registration.Mapper.DTOs.UserLogin;
public class EditUserLogin : ModelDto
{
    [Required]
    public string Code { get; set; }
    [Required]
    public string PassWord { get; set; }
}