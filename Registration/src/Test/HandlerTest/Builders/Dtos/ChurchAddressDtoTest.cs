using Registration.Mapper.DTOs.Registration.ChurchAddress;

namespace HandlersTest.Builders.Dtos;

public class ChurchAddressDtoTest
{
    public static ChurchAddress ValidObjectOne() =>
        new ChurchAddress(EditChurchDtoTest.ValidObjectOne(), EditAddressDtoTest.ValidObjectOne());

    public static ChurchAddress ValidObjectTwo() =>
        new ChurchAddress(EditChurchDtoTest.ValidObjectTwo(), EditAddressDtoTest.ValidObjectTwo());

    public static ChurchAddress InValidObjectOne() =>
        new ChurchAddress(EditChurchDtoTest.InvalidObjectOne(), EditAddressDtoTest.InvalidObjectOne());
    public static ChurchAddress InValidObjectTwo() =>
    new ChurchAddress(EditChurchDtoTest.InvalidObjectTwo(), EditAddressDtoTest.InvalidObjectTwo());
}