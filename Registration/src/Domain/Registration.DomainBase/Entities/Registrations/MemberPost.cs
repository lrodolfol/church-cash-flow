namespace Registration.DomainBase.Entities.Registrations;

public class MemberPost : Entitie
{
    public MemberPost(int id, int memberId, int postId)
    {
        Id = id;
        MemberId = memberId;
        PostId = postId;
    }

    public int MemberId { get; set; }
    public int PostId { get; set; }

    public Member Members { get; set; }
    public Post Posts { get; set; }
}
