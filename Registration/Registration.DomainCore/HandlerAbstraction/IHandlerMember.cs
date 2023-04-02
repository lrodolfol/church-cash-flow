using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;
public interface IHandlerMember<TReadDto, TEditDto> 
    where TEditDto : CModelDTO
    where TReadDto : CModelDTO
{
    public int GetStatusCode();
    public abstract Task<CViewModel> GetByCode(string userCode);
    public abstract Task<CViewModel> GetAll(bool active = true);
    public abstract Task<CViewModel> GetOne(int id);
    public abstract Task<CViewModel> Create(TEditDto churchEditDto);
    public abstract Task<CViewModel> Update(TEditDto churchEditDto, int id);
    public abstract Task<CViewModel> Delete(int id);
}