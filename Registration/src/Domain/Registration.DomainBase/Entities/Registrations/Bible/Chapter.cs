namespace Registration.DomainBase.Entities.Registrations.Bible;
public class Chapter
{
    public int Number { get; set; }
    public List<Verse> Verses { get; set; } = [];
}
