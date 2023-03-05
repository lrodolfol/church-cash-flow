using ChurchCashFlow.Data.ViewModels.Dtos;
using ChurchCashFlow.Data.ViewModels.Dtos.Address;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using System.ComponentModel.DataAnnotations;

namespace ChurchCashFlow.Data.Entities;
public class ChurchAddress : ModelDto
{
    [Required]
    public EditChurchDto EditChurchDto { get; set; }
    [Required]
    public EditAddressDto EditAddressDto { get; set; }

    public void Validate()
    {
        EditChurchDto.Validate();
        if (EditChurchDto.IsValid)
        {
            foreach (var not in EditChurchDto.Notifications)
            {
                AddNotification(not);
            }
        }
            
    }
}
