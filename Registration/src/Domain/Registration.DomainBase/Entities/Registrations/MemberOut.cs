namespace Registration.DomainBase.Entities.Registrations;

public class MemberOut : Entitie
{
    public MemberOut(string reason, DateOnly day, int memberId)
    {
        MemberId = memberId;
        Reason = reason;
        Day = day;
        Active = true;
    }

    public int MemberId { get; set; }
    public string Reason { get; set; } = null!;
    public DateOnly Day { get; set; }

    public Member? Member { get; set; }
}
