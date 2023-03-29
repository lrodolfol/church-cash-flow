using Registration.DomainCore.ViewModel;

namespace Registration.DomainCore.HandlerAbstraction;
public interface IHandlerMember<TReadDto, TEditDto> 
    where TEditDto : ModelDto
    where TReadDto : ModelDto
{
    public int GetStatusCode();
    public abstract Task<ResultViewModel<TReadDto>> GetByCode(string userCode);
    public abstract Task<ResultViewModel<IEnumerable<TReadDto>>> GetAll(bool active = true);
    public abstract Task<ResultViewModel<TReadDto>> GetOne(int id);
    public abstract Task<ResultViewModel<TReadDto>> Create(TEditDto churchEditDto);
    public abstract Task<ResultViewModel<TReadDto>> Update(TEditDto churchEditDto, int id);
    public abstract Task<ResultViewModel<TReadDto>> Delete(int id);
}