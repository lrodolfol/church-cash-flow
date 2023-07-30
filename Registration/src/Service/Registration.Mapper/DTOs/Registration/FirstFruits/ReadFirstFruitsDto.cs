namespace Registration.Mapper.DTOs.Registration.FirstFruits;
public class ReadFirstFruitsDto : ModelDto
{
    public decimal TotalAmount { get; set; }
    public DateTime? Day { get; set; }
    public string? Description { get; set; }
    public string? Competence { get; set; }
    public string? Church { get; set; }
    public string? Member { get; set; }
    public int MemberId { get; set; }
    public string? OfferingKind { get; set; }
    public int OfferingKindId { get; set; }
}