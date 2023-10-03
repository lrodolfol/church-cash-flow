using AutoMapper;
using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;
public abstract class BaseNormalHandler : BaseHandler
{
    protected IMapper _mapper;

    protected BaseNormalHandler(IMapper mapper, CViewModel viewModel) : base(viewModel)
    {
        _mapper = mapper;
    }

    public int GetStatusCode() => (int)_statusCode;

    protected virtual bool ValidateCompetence(string competence)
    {
        DateTime t;
        if (!DateTime.TryParse(competence.ToString(), out t))
            return false;

        return true;
    }

}
