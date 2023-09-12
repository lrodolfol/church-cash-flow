using Registration.Mapper.DTOs.Registration.OfferingKind;

namespace HandlersTest.Builders.Dtos;

public class EditOfferingKindDtoTest
{
    public static EditOfferingKindDto ValidObjectOne() =>
        new EditOfferingKindDto() { Id = 1, Name = "Cédulas", Description = "Oferta em R$ vivo" };

    public static EditOfferingKindDto ValidObjectTwo() =>
        new EditOfferingKindDto() { Id = 1, Name = "Pix", Description = "Transferência via pix" };

    public static EditOfferingKindDto ValidObjectThree() =>
        new EditOfferingKindDto() { Id = 1, Name = "Depósito", Description = "Depósito bancário" };
}