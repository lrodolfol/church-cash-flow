using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;
public interface IHandlerLogin<TEditDto> 
    where TEditDto : CModelDTO
{
    public int GetStatusCode();
    public abstract Task<CViewModel> Login(TEditDto userLogin);
}