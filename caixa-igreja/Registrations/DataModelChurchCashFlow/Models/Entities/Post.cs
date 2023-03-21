namespace DataModelChurchCashFlow.Models.Entities;
public class Post : Entitie
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public List<Member> Members { get; private set; }

    public Post(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public void UpdateChanges(Post editPost)
    {
        Name = editPost.Name;
        Description = editPost.Description;
    }
}