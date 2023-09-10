using HandlersTest.Builders.Dtos;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Offering;

namespace HandlersTest.Builders.Entities;

public class OfferingTest
{
    public static Offering ValidObjectOne()
    {
        var editOffering = EditOfferingDtoTest.ValidObjectOne();
        return ConvertTo(editOffering);
    }

    public static Offering ValidObjectTwo()
    {
        var editOffering = EditOfferingDtoTest.ValidObjectTwo();
        return ConvertTo(editOffering);
    }

    private static Offering ConvertTo(EditOfferingDto dto)
    {
        return new Offering(dto.Id, dto.Description! ,dto.Day, dto.Competence!, 
            dto.AdultQuantity, dto.ChildrenQuantity, dto.TotalAmount, dto.PreacherMemberName!, 
            dto.MeetingKindId, dto.MeetingKindId, dto.ChurchId);
    }
}