namespace Registration.DomainBase.Entities.Registrations;

public class MemberIn : Entitie
{
    public MemberIn(string churchName, string lastPost, string letterReceiver, int memberId)
    {
        ChurchName = churchName;
        LastPost = lastPost;
        LetterReceiver = letterReceiver;
        MemberId = memberId;
    }


    public string ChurchName { get; set; } = null!;
    public string LastPost { get; set; } = null!;
    public string LetterReceiver { get; set; } = null!;
    public int MemberId { get; set; }

    public Member? Member { get; set; }
}