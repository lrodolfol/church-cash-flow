using AutoMapper;
using ChurchCashFlow.Profiles;
using Lw.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Moq;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Registration.Mapper.DTOs.Registration.Address;
using Registration.Mapper.DTOs.Registration.Church;
using Registration.Mapper.DTOs.Registration.ChurchAddress;
using Registration.Repository;
using Registration.Repository.Repository.Registration;

namespace Registration.Test;

public class ChurchTest
{
    private readonly ChurchHandler _handler;
    private readonly IMapper _mapperMock;
    private readonly ResultViewModel _viewModel;
    private readonly ChurchContextFake _context;

    public ChurchTest()
    {

        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new ChurchProfile());
            conf.AddProfile(new AddressProfile());            
        });
        _mapperMock = confMapper.CreateMapper();

        _context = new ChurchContextFake();
        _viewModel = new ResultViewModel();  

        _handler = new ChurchHandler(_context, _mapperMock, _viewModel);
    }


    [Fact(DisplayName = "church test")]
    public void CreateNewChurch()
    {
        var editChurchDto = new EditChurchDto("CEO Soledade", "SLD", 1, 1, 1, 1, 1, 1);
        var editAddressDto = new EditAddressDto("Brasil", "Minas Gerais", "Soledade",
            "63156-000", "Centro", "Rua D. Dorival", "", 361);
        ChurchAddress churchEditDto = new ChurchAddress(editChurchDto, editAddressDto);

        var result = _handler.Create(churchEditDto);
        dynamic obj = result.Result.Data!;
        Assert.Equal(obj.Name, editChurchDto.Name); 
    }
}