namespace Registration.DomainBase.Entities.Registrations;
public class FirstFruits : Entitie
{
    public decimal TotalAmount { get; private set; }
    public string? Description { get; private set; }
    public DateTime Day { get; private set; }
    /// <summary>
    /// yyyy/MM
    /// </summary>
    public string? Competence { get; private set; }
    public int ChurchId { get; private set; }
    public int OfferingKindId { get; private set; }
    public int MemberId { get; private set; }

    public Church? Church { get; private set; }
    public Member? Member { get; private set; }
    public OfferingKind? OfferingKind { get; private set; }
    public string? Photo { get; private set; }

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

    private void SetPhoto()
    {

        Photo = $"first-fruitsCH-{ChurchId}-{CreateGuid(6)}";
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
    public void UpdateData()
    {
        SetPhoto();
    }
}