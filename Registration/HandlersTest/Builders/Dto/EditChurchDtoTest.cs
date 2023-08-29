using Registration.Mapper.DTOs.Registration.Church;

namespace HandlersTest.Builders.Dto;

public class EditChurchDtoTest
{
    public static EditChurchDto ValidObject() => new EditChurchDto("CEO Carmo", "CEO-CRM", 1, 2, 3, 4, 5, 6);
    public static EditChurchDto InvalidObject()
    {
        var name = "CEO Carmo";
        var acronym = "CEO-CRM";
        while (name.Length < 60) { name = $"{name} - {name}"; }
        while (acronym.Length < 60) { acronym = $"{acronym} - {acronym}"; }

        return new EditChurchDto(name, acronym, 1, 2, 3, 4, 5, 6);
    }
}