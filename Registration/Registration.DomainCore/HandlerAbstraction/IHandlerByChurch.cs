using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;

public interface IHandlerByChurch<TReadDto, TEditDto>
    where TReadDto : CModelDTO
    where TEditDto : CModelDTO
{
    public int GetStatusCode();
    public abstract Task<CViewModel> GetAll(int churchId, bool active = true);
    public abstract Task<CViewModel> GetOne(int id);
    public abstract Task<CViewModel> Create(TEditDto churchEditDto);
    public abstract Task<CViewModel> Update(TEditDto churchEditDto, int id);
    public abstract Task<CViewModel> Delete(int id);

}