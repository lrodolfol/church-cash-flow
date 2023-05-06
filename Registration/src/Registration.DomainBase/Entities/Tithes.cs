namespace Registration.DomainBase.Entities;
public class Tithes : Entitie
{
    public decimal TotalAmount { get; private set; }
    public DateTime? Day { get; private set; }
    public string? Competence { get; private set; }
    public int ChurchId { get; private set; }
    public int OfferingKindId { get; private set; }
    public int MemberId { get; private set; }

    public Church? Church { get; private set; }
    public Member? Member { get; private set; }
    public OfferingKind? OfferingKind { get; private set; }

    public Tithes(int id, decimal totalAmount, DateTime day, string competence, int churchId, int memberId, int offeringKindId)
    {
        Id = id;
        TotalAmount = totalAmount;
        Day = day;
        Competence = competence;
        ChurchId = churchId;
        MemberId = memberId;
        OfferingKindId = offeringKindId;
    }

    public Tithes()
    {
    }

    public void UpdateChanges(Tithes tithesEdit)
    {
        TotalAmount = tithesEdit.TotalAmount;
        Day = tithesEdit.Day;
        Competence = tithesEdit.Competence;
        ChurchId = tithesEdit.ChurchId;
        OfferingKindId = tithesEdit.OfferingKindId;
        MemberId = tithesEdit.MemberId;
    }
}