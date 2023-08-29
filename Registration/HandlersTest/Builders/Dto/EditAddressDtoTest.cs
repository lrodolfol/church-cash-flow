using Registration.Mapper.DTOs.Registration.Address;

namespace HandlersTest.Builders.Dto;

public class EditAddressDtoTest
{
    public static EditAddressDto ValidObject() => 
        new EditAddressDto("Brasil", "Minas Gerais", "Carmos de minas", "37490-000", "Centro", "Rua projetada", "", 1042);

    public static EditAddressDto InvalidObject() =>
        new EditAddressDto("", "", "Carmos de minas", "37490-000", "Centro", "Rua projetada", "", 0);
}