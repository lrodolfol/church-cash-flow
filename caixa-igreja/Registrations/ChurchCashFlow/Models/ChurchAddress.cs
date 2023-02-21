using ChurchCashFlow.ViewModels.Dtos.Address;
using ChurchCashFlow.ViewModels.Dtos.Church;
using System.ComponentModel.DataAnnotations;

namespace ChurchCashFlow.Models;
public class ChurchAddress
{
    [Required]
    public EditChurchDto EditChurchDto { get; set; }
    [Required]
    public EditAddressDto EditAddressDto { get; set; }
}
