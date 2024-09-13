using HandlersTest.Builders.Dtos;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.MonthWork;

namespace HandlersTest.Builders.Entities;

public class MonthWorkTest : Entitie
{
    public static MonthWork? ValidObjectOneBlock()
    {
        var dto = EditMonthWorkDtoTest.ValidObjectOneBlock();
        return ConvertTo(dto);
    }

    public static MonthWork? ValidObjectOneUnblock()
    {
        var dto = EditMonthWorkDtoTest.ValidObjectOneUnblock();
        return ConvertTo(dto);
    }

    private static MonthWork ConvertTo(EditMonthWorkDto dto) =>
        new MonthWork(dto.Id, dto.YearMonth, dto.ChurchId);
        
}