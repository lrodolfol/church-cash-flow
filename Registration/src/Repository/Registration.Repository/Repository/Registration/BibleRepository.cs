using MongoDB.Driver;
using Registration.DomainBase.Entities.Registrations.Bible;
using Registration.DomainCore.ContextAbstraction;
using Registration.Mapper.DTOs.Registration.Bible;

namespace Registration.Repository.Repository.Registration;
public class BibleRepository : IBibleRepository
{
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<BibleBook> _collection;

    public BibleRepository(IMongoDatabase database)
    {
        _database = database;
        _collection = _database.GetCollection<BibleBook>("books");
    }

    public async Task<List<Verse>> GetAsync(GetBibleDto dto)
    {
        // Filtro para buscar o livro e o capitulo especifico
        FilterDefinition<BibleBook> filter = Builders<BibleBook>.Filter.And(
            Builders<BibleBook>.Filter.Eq(x => x.Name, dto.Book),
            Builders<BibleBook>.Filter.ElemMatch(x => x.Chapters, c => c.Number == dto.Chapter)
        );

        // Busca o livro que contem o capitulo e retorna apenas o capitulo correspondente
        Chapter? chapter = (await _collection
            .Find(filter)
            .Project(book => book.Chapters.FirstOrDefault(c => c.Number == dto.Chapter)) // Projeta somente o capitulo desejado
            .FirstOrDefaultAsync());

        List<Verse> verses = [];

        if (chapter is null)
            return verses;

        if (dto.Verses is null || dto.Verses.Count() <= 0)
            verses = chapter.Verses;
        else
            verses.AddRange(chapter.Verses.FindAll(v => dto.Verses.Contains(v.Number)));

        return verses;
    }

    public async Task<BibleBook> GetRandAsync()
    {
        var rand = new Random();
        var num = rand.Next(1, 67);

        FilterDefinition<BibleBook> filter = Builders<BibleBook>.Filter.And(
            Builders<BibleBook>.Filter.Eq(x => x.Number, num),
            Builders<BibleBook>.Filter.ElemMatch(x => x.Chapters, c => c.Number > 0)
        );

        BibleBook? bible = (await _collection
            .Find(filter)
            .FirstOrDefaultAsync());

        num = rand.Next(1, bible.Chapters.Count+1);
        Chapter? chapter = bible.Chapters.FirstOrDefault(x => x.Number == num);

        num = rand.Next(1, chapter.Verses.Count+1);
        Verse? verse = chapter!.Verses.FirstOrDefault(x => x.Number == num);

        chapter.Verses = new List<Verse>() { verse! };
        bible.Chapters = new List<Chapter>() { chapter };

        return bible;
    }
}
