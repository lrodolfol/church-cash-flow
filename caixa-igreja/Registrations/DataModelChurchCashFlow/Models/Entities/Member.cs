namespace DataModelChurchCashFlow.Models.Entities;
public class Member : Entitie
{
    public string Code { get; private set; }
    public string Name { get; private set; }
    public DateTime DateBirth { get; private set; }
    public Post Post{ get; private set; }
    public Church Church { get; private set; }
    public int PostId { get; private set; }
    public int ChurchId { get; private set; }

    public Member(int id, string name, DateTime dateBirth, int postId, int churchId)
    {
        Id = id;
        Name = name;
        DateBirth = dateBirth;
        PostId = postId;
        ChurchId = churchId;
    }

    public void UpdateChanges(Member member)
    {
        Name = member.Name;
        DateBirth= member.DateBirth;
        PostId = member.PostId;
        ChurchId = member.ChurchId;
    }
    public void GenerateCode()
    {
        var code = $"{Church.Acronym}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}";
        Code = code;
    }

    public void AddChurch(Church church)
    {
        Church = church;
    }
}
