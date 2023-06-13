namespace Registration.DomainBase.Entities.Operations;

public class MonthlyOffers
{
    public string? PreacherMemberName { get; set; }
    public DateTime Day { get; set; }
    public string? Competence { get; set; }
    public decimal TotalAmount { get; set; }
    public int AdultQuantity { get; set; }
    public int ChildrenQuantity { get; set; }
    public int PeopleQuantity { get; set; }
    public string? MeetingName { get; set; }
    public string? OfferingName { get; set; }
}
