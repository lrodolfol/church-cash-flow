using AutoMapper;
using Moq;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest;

public class HandlerTest
{
    protected ResultViewModel viewModel = null!;
    protected Mock<ILogger> logger = null!;
    protected IMapper? mapper;
}