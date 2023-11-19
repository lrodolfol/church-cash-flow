using HandlersTest.Builders.Entities;
using Registration.Mapper.DTOs.Registration.Church;

namespace HandlersTest.Builders.Dto;

public class EditChurchDtoTest
{
    public static EditChurchDto ValidObjectOne()
    {
        var church = ChurchTest.ValidObjectOne();
        var editChurch = new EditChurchDto(church.Name!, church.Acronym!, new DateTime(2023, 11, 17), new DateTime(2023, 11, 17), 1, 2, 3, 4, 5, 6);

        return editChurch;
    }
    public static EditChurchDto ValidObjectTwo()
    {
        var church = ChurchTest.ValidObjectTwo();
        var editChurch = new EditChurchDto(church.Name!, church.Acronym!, new DateTime(2023, 11, 17), new DateTime(2023, 11, 17), 1, 2, 3, 4, 5, 6);

        return editChurch;
    }
    public static EditChurchDto InvalidObjectOne()
    {
        var church = ValidObjectOne();

        while (church.Name.Length < 60) { church.Name = $"{church.Name} - {church.Name}"; }
        while (church.Acronym.Length < 60) { church.Acronym = $"{church.Acronym} - {church.Acronym}"; }

        return church;
    }
    public static EditChurchDto InvalidObjectTwo()
    {
        var church = ValidObjectTwo();

        while (church.Name.Length < 60) { church.Name = $"{church.Name} - {church.Name}"; }
        while (church.Acronym.Length < 60) { church.Acronym = $"{church.Acronym} - {church.Acronym}"; }

        return church;
    }

}