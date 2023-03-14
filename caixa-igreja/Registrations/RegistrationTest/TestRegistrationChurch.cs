using AutoMapper;
using ChurchCashFlow.Data.Entities;
using ChurchCashFlow.Data.ViewModels.Dtos.Address;
using ChurchCashFlow.Data.ViewModels.Dtos.Church;
using ChurchCashFlow.Handlers;
using ChurchCashFlow.Profiles;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Entities;
using RegistrationTest.ContextFake;
using System.Linq;

namespace RegistrationTest;

public class TestRegistrationChurch
{
    private readonly IChurchContext _fakeContext = new ChurchContextFake();
    private IMapper _mapper;
    private readonly ChurchHandler _handler;

    public TestRegistrationChurch()
    {
        MapperConfiguration confMapper = new MapperConfiguration(conf =>
        {
            conf.AddProfile(new ChurchProfile());
            conf.AddProfile(new AddressProfile());
        });

        _mapper = confMapper.CreateMapper();

        _handler = new ChurchHandler(_fakeContext, _mapper);
    }

    [Fact]
    [Trait("Xunit", "Add New Church")]
    public void ShouldAddNewChurchNormally()
    {
        var editChurchDto = new EditChurchDto("CEO Baipendi");
        var editAddressDto = new EditAddressDto("Brasil", "Minas Gerais", "Baipendi",
            "125896012", "Nª Sr de Lourdes", "Rua S/ saida II", "", 1023);

        var churchAddress = new ChurchAddress(editChurchDto, editAddressDto);

        var resultViewModel = _handler.Create(churchAddress);

        Assert.Equal(editChurchDto.Name, resultViewModel.Result.Data.Name);
    }

    [Fact]
    [Trait("Xunit", "Add New Church Without Address")]
    public void CannotAddNewChurchWithOutAddress()
    {
        var editChurchDto = new EditChurchDto("CEO Baipendi");
        var editAddressDto = new EditAddressDto("", "", "", "", "", "", "", 0);

        var churchAddress = new ChurchAddress(editChurchDto, editAddressDto);

        var resultViewModel = _handler.Create(churchAddress);

        Assert.NotNull(resultViewModel.Result.Errors);
    }

    [Fact]
    [Trait("Xunit", "Update a Church")]
    public void ShouldUpdateChurchNormally()
    {
        var church = ChurchContextFake.Churches.First();
        church.Name = "CEO Itaguai";
        var address = ChurchContextFake.Adresses.Find(x => x.Id == church.AddressId);

        var churchEditDto = new EditChurchDto(church.Name);
        var addressEditDto = new EditAddressDto(address.Country, address.State, address.City, address.ZipCode,
            address.District, address.Street, address.Additional, address.Number);

        var churchAddress = new ChurchAddress(churchEditDto, addressEditDto);
        var resultViewModel = _handler.Update(churchAddress, church.Id);

        Assert.True(resultViewModel.Result.Data.Name == "CEO Itaguai");
    }

}