using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;

public class BaseHandler
{
    protected readonly CViewModel _viewModel;
    protected int _statusCode;
    protected TimeSpan TimeToExpirationCache = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59) - DateTime.Now;

    public BaseHandler(CViewModel viewModel)
    {
        _viewModel = viewModel;
    } 
}