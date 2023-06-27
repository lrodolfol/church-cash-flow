using AutoMapper;
using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;
public abstract class BaseOpersHandler : BaseHandler
{
    public int GetStatusCode() => (int)_statusCode;

    protected BaseOpersHandler(CViewModel viewModel) : base(viewModel)
    {
    }

    protected virtual bool ValidateCompetence(string competence)
    {
        DateTime t;
        if (!DateTime.TryParse(competence.ToString(), out t))
            return false;

        return true;
    }

}
