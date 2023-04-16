namespace Registration.DomainBase.Entities;
public class Offering : Entitie
{
    public DateTime Day { get; private set; }
    public int AdultQuantity { get; private set; }
    public int ChildrenQuantity { get; private set; }
    public decimal TotalAmount{ get; private set; }
    public string PreacherMemberName { get; private set; }
    public int MeetingKindId { get; private set; }
    public int OfferingKindId { get; private set; }
    public int ChurchId { get; private set; }

    public Church Church { get; private set; }
    public MeetingKind MeetingKind { get; private set; }
    public OfferingKind OfferingKind { get; private set; }

    public Offering()
    {
    }

    public Offering(int id, DateTime day, int adultQuantity, int childrenQuantity, decimal totalAmount, 
        string preacherMemberName, int meetingKindId, int offeringKindId, int churchId)
    {
        Id = id;
        Day = day;
        AdultQuantity = adultQuantity;
        ChildrenQuantity = childrenQuantity;
        TotalAmount = totalAmount;
        PreacherMemberName = preacherMemberName;
        MeetingKindId = meetingKindId;
        OfferingKindId = offeringKindId;
        ChurchId = churchId;
    }

    public void UpdateChanges(Offering editOffering)
    {
        Day = editOffering.Day;
        AdultQuantity = editOffering.AdultQuantity;
        ChildrenQuantity = editOffering.ChildrenQuantity; 
        TotalAmount = editOffering.TotalAmount;
        PreacherMemberName = editOffering.PreacherMemberName;
        MeetingKind = editOffering.MeetingKind;
        OfferingKindId = editOffering.OfferingKindId;
        ChurchId = editOffering.ChurchId;
    }
}