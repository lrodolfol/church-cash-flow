namespace Registration.DomainBase.Entities.Registrations;

public class MemberOut : Entitie
{
    public MemberOut(int id, int memberId, string reason, DateOnly day)
    {
        Id = id;
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
