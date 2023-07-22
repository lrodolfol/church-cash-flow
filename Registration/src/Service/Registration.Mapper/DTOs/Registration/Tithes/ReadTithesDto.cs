namespace Registration.Mapper.DTOs.Registration.Tithes;
public class ReadTithesDto : ModelDto
{
    public decimal TotalAmount { get; set; }
    public DateTime? Day { get; set; }
    public string? Description { get; set; }
    public string? Competence { get; set; }
    public string? Church { get; set; }
    public string? Member { get; set; }
    public string? OfferingKind { get; set; }
    public int MemberId { get; set; }
    public int OfferingKindId { get; set; }
}