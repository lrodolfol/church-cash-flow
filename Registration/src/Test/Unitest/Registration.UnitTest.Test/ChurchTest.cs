using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Mapper.DTOs.Registration.ChurchAddress;
using Registration.Repository;
using Registration.UnitTest.Test.Builders;
using System.Collections;

namespace Registration.UnitTest.Test;

[Collection(nameof(ChurchBuilders))]
public class ChurchTest : BaseUnitTest, IDisposable
{
    private readonly ChurchBuilders _fixture;

    public ChurchTest(ChurchBuilders fixture) =>
        _fixture = fixture;    

    [Fact(DisplayName = nameof(Create))]
    [Trait("Domain","Church - create")]
    public async void Create()
    {
        DomainCore.ContextAbstraction.IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();
        ChurchAddress churchAddress = _fixture.GetValidChurchAddress();

        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);
        CViewModel handResult = await hand.Create(churchAddress);

        Assert.NotNull(handResult);
        Assert.NotNull(handResult.Data);
        Assert.True(handResult.Errors.Count == 0);
    }

    [Fact(DisplayName = nameof(GetAll))]
    [Trait("Domain", "Church - getAll")]
    public async void GetAll()
    {
        var repository = _fixture.GetRepository();
        var mapper = _fixture.GetMapper();
        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);
        CViewModel handResult;

        int cont = 0;
        do
        {
            ChurchAddress churchAddress = _fixture.GetValidChurchAddress();
            handResult = await hand.Create(churchAddress);
            cont++;
        } while (cont < 10);

        handResult = await hand.GetAll();
        IEnumerable? resultObj = handResult.Data as IEnumerable;
        int countResult = resultObj.Cast<object>().Count();

        Assert.NotNull(handResult);
        Assert.True(countResult == cont);
        Assert.True(handResult.Errors.Count == 0);
    }

    [Fact(DisplayName = nameof(Update))]
    [Trait("Domain", "Church - update")]
    public async Task Update()
    {
        Church church = _fixture.GetValidEntitie();
        DataContext context = _fixture.GetContext();
        await context.Churches.AddAsync(church);
        await context.SaveChangesAsync();

        _fixture.ReloadFaker();
        ChurchAddress churchAddress = _fixture.GetValidChurchAddress();

        IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();
        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);
        
        var newHandResult = await hand.Update(churchAddress, church.Id);
        var churchUpdated = await context.Churches.SingleOrDefaultAsync(x => x.Id == church.Id);

        Assert.Equal(churchUpdated!.Name, churchAddress.EditChurchDto.Name);
        Assert.Equal(churchUpdated.Acronym, churchAddress.EditChurchDto.Acronym);
        Assert.Equal(churchUpdated.Address!.Street, churchAddress.EditAddressDto.Street);
        Assert.Equal(churchUpdated.Address.City, churchAddress.EditAddressDto.City);
    }

    [Fact(DisplayName = nameof(Delete))]
    [Trait("Domain", "Church - delete")]
    public async Task Delete()
    {
        Church church = _fixture.GetValidEntitie();
        DataContext context = _fixture.GetContext();
        await context.Churches.AddAsync(church);
        await context.SaveChangesAsync();

        IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();
        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);

        var newHandResult = await hand.Delete(church.Id);
        var churchUpdated = await context.Churches.SingleOrDefaultAsync(x => x.Id == church.Id);

        Assert.False(churchUpdated!.Active);
    }

    public void Dispose() => 
        _fixture.ClearContext();
}