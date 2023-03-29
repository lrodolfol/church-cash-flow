using Registration.DomainCore.ViewModel;

namespace Registration.DomainCore.HandlerAbstraction;
public interface IHandlerLogin<TEditDto> 
    where TEditDto : ModelDto
{
    public int GetStatusCode();
    public abstract Task<ResultViewModel<string>> Login(TEditDto userLogin);
}