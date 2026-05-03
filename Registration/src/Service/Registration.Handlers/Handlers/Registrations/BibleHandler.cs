using Registration.DomainBase.Entities.Registrations.Bible;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Registration.Bible;
using Serilog;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers.Registrations;
public class BibleHandler
{
    private readonly IBibleRepository _repository;
    private readonly CViewModel _viewModel;
    private readonly ILogger _logger;
    public int StatusCode { get; private set; }

    public BibleHandler(CViewModel viewModel, IBibleRepository repository, ILogger logger)
    {
        _viewModel = viewModel;
        _repository = repository;
        _logger = logger;
    }

    public async Task<CViewModel> Get(GetBibleDto dto)
    {
        List<Verse>? verses = await _repository.GetAsync(dto);
        if (!verses.Any())
        {
            _viewModel.SetErrors("Verses not found");
            StatusCode = (int)Scode.NOT_FOUND;

            return _viewModel;
        }

        ReadBiblieDto read = dto;
        read.Verses = verses;

        _viewModel.SetData(read);
        StatusCode = (int)Scode.OK;

        return _viewModel;
    }
    public async Task<CViewModel> GetRandAsync()
    {
        ReadBiblieDto read;

        try
        {
            BibleBook bible = await _repository.GetRandAsync();
            if (bible is null)
                read = getPatternVerse();
            else
                read = bible;
        }
        catch(Exception e)
        {
            _logger.Error("Fail to read verson from biblie {err}", e.Message);
            read = getPatternVerse();
        }

        _viewModel.SetData(read);
        StatusCode = (int)Scode.OK;

        return _viewModel;
    }

    private static ReadBiblieDto getPatternVerse()
    {
        return new ReadBiblieDto
        {
            Book = "João",
            Chapter = 8,
            Verses = new List<Verse>
                {
                    new Verse
                    {
                        Number = 32,
                        Text = "E conhecereis a verdade, e a verdade vos libertará."
                    }
                }
        };
    }
}
