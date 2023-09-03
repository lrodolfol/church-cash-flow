using HandlersTest.Builders.Dtos;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.OfferingKind;

namespace HandlersTest.Builders.Entities;

public class OfferingKindTest
{
    public static OfferingKind ValidObjectOne()
    {
        var dto = EditOfferingKindDtoTest.ValidObjectOne();
        return ConvertTo(dto);
    }

    public static OfferingKind ValidObjectTwo()
    {
        var dto = EditOfferingKindDtoTest.ValidObjectTwo();
        return ConvertTo(dto);
    }

    private static OfferingKind ConvertTo(EditOfferingKindDto dto) =>
        new OfferingKind(dto.Id, dto.Name, dto.Description);
}