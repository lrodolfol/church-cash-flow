using AutoMapper;
using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;
public abstract class BaseRegisterNormalHandler : BaseHandler
{
    protected IMapper _mapper;

    public int GetStatusCode() => (int)_statusCode;

    protected BaseRegisterNormalHandler(IMapper mapper, CViewModel viewModel) : base (viewModel)
    {
        _mapper = mapper;
    }

    protected virtual bool ValidateCompetence(string competence)
    {
        if (competence is null)
            return false;

        DateTime t;
        if (!DateTime.TryParse(competence.ToString(), out t))
            return false;

        return true;
    }

    protected abstract Task<bool> MonthWorkIsBlock(string competence, int churchId);

}
