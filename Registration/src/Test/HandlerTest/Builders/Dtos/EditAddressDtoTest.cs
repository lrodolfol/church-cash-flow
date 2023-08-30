using HandlersTest.Builders.Entities;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Address;

namespace HandlersTest.Builders.Dto;

public class EditAddressDtoTest
{
    public static EditAddressDto ValidObjectOne()
    {
        var address = AddressTest.ValidObjectOne();
        return TurnEditAddress(address);
    }
    public static EditAddressDto ValidObjectTwo()
    {
        var address = AddressTest.ValidObjectTwo();
        return TurnEditAddress(address);
    }

    public static EditAddressDto InvalidObjectOne()
    {
        var address = AddressTest.InvalidObjectOne();
        return TurnEditAddress(address);
    }

    public static EditAddressDto InvalidObjectTwo()
    {
        var address = AddressTest.InvalidObjectTwo();
        return TurnEditAddress(address);
    }

    private static EditAddressDto TurnEditAddress(Address address) =>
        new EditAddressDto(address.Country!, address.State!, address.City!, address.ZipCode!,
            address.District, address.Street, address.Additional, address.Number);

}