namespace Registration.Mapper.DTOs.Registration.Offering;
public class ReadOfferingDto : ModelDto
{
    public DateTime Day { get; set; }
    public int AdultQuantity { get; set; }
    public string? Description { get; set; }
    public string? Competence { get; set; }
    public int ChildrenQuantity { get; set; }
    public decimal TotalAmount { get; set; }
    public string? PreacherMemberName { get; set; }
    public string? MeetingKind { get; set; }
    public string? OfferingKind { get; set; }
    public string? Church { get; set; }
}
