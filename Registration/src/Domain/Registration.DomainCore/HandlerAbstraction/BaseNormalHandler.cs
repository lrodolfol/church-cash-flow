using AutoMapper;
using Registration.DomainCore.ViewModelAbstraction;
using Serilog;

namespace Registration.DomainCore.HandlerAbstraction;
public abstract class BaseNormalHandler : BaseHandler
{
    protected IMapper _mapper;
    private readonly ILogger _logger;

    protected BaseNormalHandler(IMapper mapper, CViewModel viewModel, ILogger logger) : base(viewModel)
    {
        _mapper = mapper;
        _logger = logger;
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
