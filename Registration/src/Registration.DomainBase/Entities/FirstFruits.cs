namespace Registration.DomainBase.Entities;
public class FirstFruits : Entitie
{
    public decimal TotalAmount { get; private set; }
    public string? Description { get; private set; }
    public DateTime Day { get; private set; }
    public string? Competence { get; private set; }
    public int ChurchId { get; private set; }
    public int OfferingKindId { get; private set; }
    public int MemberId { get; private set; }

    public Church? Church { get; private set; }
    public Member? Member { get; private set; }
    public OfferingKind? OfferingKind { get; private set; }

    public FirstFruits(int id, string description, decimal totalAmount, DateTime day, string competence, int churchId, int memberId, int offeringKindId)
    {
        Id = id;
        Description = description;
        TotalAmount = totalAmount;
        Day = day;
        Competence = competence;
        ChurchId = churchId;
        MemberId = memberId;
        OfferingKindId = offeringKindId;
    }

    public FirstFruits()
    {
    }

    public void UpdateChanges(FirstFruits firstFruitsEdit)
    {
        TotalAmount = firstFruitsEdit.TotalAmount;
        Description = firstFruitsEdit.Description;
        Day = firstFruitsEdit.Day;
        Competence = firstFruitsEdit.Competence;
        ChurchId = firstFruitsEdit.ChurchId;
        OfferingKindId = firstFruitsEdit.OfferingKindId;
        MemberId = firstFruitsEdit.MemberId;
    }
}