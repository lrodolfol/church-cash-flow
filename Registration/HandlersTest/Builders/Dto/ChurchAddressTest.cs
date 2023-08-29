using Registration.Mapper.DTOs.Registration.ChurchAddress;

namespace HandlersTest.Builders.Dto;

public class ChurchAddressTest
{
    public ChurchAddress ValidObject() =>
        new ChurchAddress(EditChurchDtoTest.ValidObject(), EditAddressDtoTest.ValidObject());
}