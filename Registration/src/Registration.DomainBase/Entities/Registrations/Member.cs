namespace Registration.DomainBase.Entities.Registrations;
public class Member : Entitie
{
    public string? Code { get; private set; }
    public string? Name { get; private set; }
    public DateTime? DateBirth { get; private set; }
    public Post? Post { get; private set; }
    public Church? Church { get; private set; }
    public int PostId { get; private set; }
    public int ChurchId { get; private set; }

    public List<Offering>? Offerings { get; private set; }
    public List<Tithes>? Tithes { get; private set; }
    public List<FirstFruits>? FirstFruits { get; private set; }

    public Member(int id, string name, DateTime dateBirth, int postId, int churchId)
    {
        Id = id;
        Name = name;
        DateBirth = dateBirth;
        PostId = postId;
        ChurchId = churchId;
    }
    public Member(int id, string name, DateTime dateBirth, int postId, int churchId, string code)
    {
        Id = id;
        Name = name;
        DateBirth = dateBirth;
        PostId = postId;
        ChurchId = churchId;
        Code = code;
    }

    public Member()
    {
    }

    public void UpdateChanges(Member member)
    {
        Name = member.Name;
        DateBirth = member.DateBirth;
        PostId = member.PostId;
        ChurchId = member.ChurchId;
    }
    public void GenerateCode()
    {
        var code = $"{Church!.Acronym}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}";
        Code = code;
    }

    public void AddChurch(Church church)
    {
        Church = church;
    }
}
