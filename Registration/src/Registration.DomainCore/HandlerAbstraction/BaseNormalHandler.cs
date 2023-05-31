using AutoMapper;
using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;
public abstract class BaseNormalHandler
{
    protected IMapper _mapper;
    protected readonly CViewModel _viewModel;
    protected int _statusCode;
    
    public int GetStatusCode() => (int)_statusCode;

    protected BaseNormalHandler(IMapper mapper, CViewModel viewModel)
    {
        _mapper = mapper;
        _viewModel = viewModel;
    }

    protected virtual bool ValidateCompetence(string competence)
    {
        DateTime t;
        if (!DateTime.TryParse(competence.ToString(), out t))
            return false;

        return true;
    }

}
