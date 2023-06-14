using Registration.DomainCore.ViewModelAbstraction;

namespace Registration.DomainCore.HandlerAbstraction;

public class BaseHandler
{
    protected readonly CViewModel _viewModel;
    protected int _statusCode;

    public BaseHandler(CViewModel viewModel)
    {
        _viewModel = viewModel;
    } 
}