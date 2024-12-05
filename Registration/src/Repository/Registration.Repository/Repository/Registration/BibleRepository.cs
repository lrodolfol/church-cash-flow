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

        if(chapter is null)
            return verses;

        if (dto.Verses is null || dto.Verses.Count() <= 0)
            verses = chapter.Verses;
        else
            verses.Add(chapter.Verses.SingleOrDefault(v => dto.Verses.Contains(v.Number), new Verse()));
       
        return verses;
    }
}
