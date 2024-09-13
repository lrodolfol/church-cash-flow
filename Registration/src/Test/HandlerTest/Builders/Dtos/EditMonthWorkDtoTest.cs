using HandlersTest.Builders.Entities;
using Registration.Mapper.DTOs.Registration.MonthWork;

namespace HandlersTest.Builders.Dtos;

public class EditMonthWorkDtoTest
{
    public static EditMonthWorkDto ValidObjectOneBlock() =>
        new EditMonthWorkDto()
        { Id = 1, Active = true, YearMonth = int.Parse($"{DateTime.Now.ToString("yyyy")}{DateTime.Now.ToString("MM")}") ,ChurchId = ChurchTest.ValidObjectOne().Id };

    public static EditMonthWorkDto ValidObjectOneUnblock() =>
        new EditMonthWorkDto()
        { Id = 2, Active = true, YearMonth = int.Parse($"{DateTime.Now.ToString("yyyy")}{DateTime.Now.ToString("MM")}"), ChurchId = ChurchTest.ValidObjectOne().Id };
}