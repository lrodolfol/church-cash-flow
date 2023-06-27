using Registration.Mapper.DTOs.Registration.Address;
using Registration.Mapper.DTOs.Registration.Church;
using System.ComponentModel.DataAnnotations;

namespace Registration.Mapper.DTOs.Registration.ChurchAddress;
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
