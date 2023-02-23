using ChurchCashFlow.Data.ViewModels.Dtos.Address;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using System.ComponentModel.DataAnnotations;

namespace ChurchCashFlow.Data.Entities;
public class ChurchAddress
{
    [Required]
    public EditChurchDto EditChurchDto { get; set; }
    [Required]
    public EditAddressDto EditAddressDto { get; set; }
}
