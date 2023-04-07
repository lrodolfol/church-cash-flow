using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;
public abstract class Handler
{
    protected virtual bool ValidateCompetence(string competence)
    {
        DateTime t;
        if (!DateTime.TryParse(competence.ToString(), out t))
            return false;

        return true;
    }
}
