using ChurchCashFlow.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace ChurchCashFlow.Data.ViewModels.Dtos.User;
public class EditUserDto
{
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
    public string Name { get; set; }
    [Required]
    [StringLength(8, MinimumLength = 6, ErrorMessage = "Name must be between 6 and 8 characters")]
    public string PassWordHash { get; set; }
    public bool? Active { get; set; } = true;
    public int ChurchId { get; set; }
    public int RoleId { get; set; }
}
