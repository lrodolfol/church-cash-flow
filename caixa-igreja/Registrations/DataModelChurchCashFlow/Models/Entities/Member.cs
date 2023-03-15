namespace DataModelChurchCashFlow.Models.Entities;
public class Member : Entitie
{
    public string Name { get; private set; }
    public DateTime DateBirth { get; private set; }
    public Post Post{ get; private set; }
    public int PostId { get; private set; }

    public Member(int id, string name, DateTime dateBirth, int postId)
    {
        Id = id;
        Name = name;
        DateBirth = dateBirth;
        PostId = postId;
    }
}
