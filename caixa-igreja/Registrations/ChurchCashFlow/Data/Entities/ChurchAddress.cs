using ChurchCashFlow.Data.ViewModels.Dtos;
using ChurchCashFlow.Data.ViewModels.Dtos.Address;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using System.ComponentModel.DataAnnotations;

namespace ChurchCashFlow.Data.Entities;
public class ChurchAddress : ModelDto
{
    [Required]
    public EditChurchDto EditChurchDto { get; private set; }
    [Required]
    public EditAddressDto EditAddressDto { get; private set; }

    public ChurchAddress(EditChurchDto editChurchDto, EditAddressDto editAddressDto)
    {
        EditChurchDto = editChurchDto;
        EditAddressDto = editAddressDto;
    }

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

        EditAddressDto.Validate();
        if (EditAddressDto.IsValid)
        {
            foreach (var not in EditAddressDto.Notifications)
            {
                AddNotification(not);
            }
        }

    }
}
