using HandlersTest.Builders.Entities;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Offering;

namespace HandlersTest.Builders.Dtos;

public class EditOfferingDtoTest
{
    public static EditOfferingDto ValidObjectOne()
    {
        var memberOne = MemberTest.ValidObjectOne();
        var memberTwo = MemberTest.ValidObjectTwo();

        var offeringKind = OfferingKindTest.ValidObjectOne();
        var meetingKind = MeetingKingTest.ValidObjectOne();

        var church = ChurchTest.ValidObjectOne();
        var EditOfferingDto = new EditOfferingDto()
        {
            Id = 1,
            Description = $"Oferta do irmao {memberOne.Name}",
            Day = DateTime.Now.AddDays(-1),
            Competence = DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM"),
            AdultQuantity = 5,
            ChildrenQuantity = 12,
            TotalAmount = 328.65m,
            PreacherMemberName = memberTwo.Name!,
            OfferingKindId = offeringKind.Id,
            MeetingKindId = meetingKind.Id,
            ChurchId = church.Id
        };

        return EditOfferingDto;
    }

    public static EditOfferingDto ValidObjectTwo()
    {
        var memberOne = MemberTest.ValidObjectTwo();
        var memberTwo = MemberTest.ValidObjectOne();

        var offeringKind = OfferingKindTest.ValidObjectTwo();
        var meetingKind = MeetingKingTest.ValidObjectTwo();

        var church = ChurchTest.ValidObjectTwo();
        var EditOfferingDto = new EditOfferingDto()
        {
            Id = 2,
            Description = $"Oferta do irmao {memberOne.Name}",
            Day = DateTime.Now.AddDays(-10),
            Competence = DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM"),
            AdultQuantity = 54,
            ChildrenQuantity = 12,
            TotalAmount = 30.00m,
            PreacherMemberName = memberTwo.Name!,
            OfferingKindId = offeringKind.Id,
            MeetingKindId = meetingKind.Id,
            ChurchId = church.Id
        };

        return EditOfferingDto;
    }
}