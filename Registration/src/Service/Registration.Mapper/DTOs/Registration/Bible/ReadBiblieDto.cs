using Registration.DomainBase.Entities.Registrations.Bible;

namespace Registration.Mapper.DTOs.Registration.Bible;
public class ReadBiblieDto
{
    public string Book { get; set; } = null!;
    public int Chapter { get; set; }
    public List<Verse>? Verses { get; set; }


    public static implicit operator ReadBiblieDto(GetBibleDto entitie)
    {
        return new ReadBiblieDto
        {
            Book = entitie.Book,
            Chapter = entitie.Chapter
        };
    }
}