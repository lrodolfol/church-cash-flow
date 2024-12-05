using Registration.DomainBase.Entities.Registrations.Bible;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Registration.Bible;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers.Registrations;
public class BibleHandler
{
    private readonly IBibleRepository _repository;
    private readonly CViewModel _viewModel;
    public int StatusCode { get; private set; }

    public BibleHandler(CViewModel viewModel, IBibleRepository repository)
    {
        _viewModel = viewModel;
        _repository = repository;
    }

    public async Task<CViewModel> Get(GetBibleDto dto)
    {
        List<Verse>? verses = await _repository.GetAsync(dto);
        if (!verses.Any()) {
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
}
