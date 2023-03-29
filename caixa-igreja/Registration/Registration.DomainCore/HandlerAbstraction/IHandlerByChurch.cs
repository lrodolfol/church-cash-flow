using Registration.DomainCore.ViewModel;

namespace Registration.DomainCore.HandlerAbstraction;

public interface IHandlerByChurch<TReadDto, TEditDto>
    where TReadDto : ModelDto
    where TEditDto : ModelDto
{
    public int GetStatusCode();
    public abstract Task<ResultViewModel<IEnumerable<TReadDto>>> GetAll(int churchId, bool active = true);
    public abstract Task<ResultViewModel<TReadDto>> GetOne(int id);
    public abstract Task<ResultViewModel<TReadDto>> Create(TEditDto churchEditDto);
    public abstract Task<ResultViewModel<TReadDto>> Update(TEditDto churchEditDto, int id);
    public abstract Task<ResultViewModel<TReadDto>> Delete(int id);

}