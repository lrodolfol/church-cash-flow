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

    public ChurchTest(ChurchBuilders fixture)
    {
        _fixture = fixture;
        _fixture.Initialize();
    }

    [Fact(DisplayName = nameof(Create))]
    [Trait("Domain", "Church - create")]
    public async void Create()
    {
        IChurchRepository repository = _fixture.GetRepository();
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
        IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();
        DataContext context = _fixture.GetContext();
        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);
        CViewModel handResult;

        int cont = 0;
        do
        {
            Church church = _fixture.GetValidEntitie();
            await context.Churches.AddAsync(church);
            cont++;
        } while (cont < 10);
        await context.SaveChangesAsync();

        handResult = await hand.GetAll();
        IEnumerable? resultObj = handResult.Data as IEnumerable;
        int countResult = resultObj!.Cast<object>().Count();

        Assert.NotNull(handResult);
        Assert.True(countResult == cont);
        Assert.True(handResult.Errors.Count == 0);
    }

    [Fact(DisplayName = nameof(GetOneById))]
    [Trait("Domain", "Church - GetOneById")]
    public async void GetOneById()
    {
        IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();
        DataContext context = _fixture.GetContext();
        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);

        Church church = _fixture.GetValidEntitie();
        await context.Churches.AddAsync(church);
        await context.SaveChangesAsync();

        dynamic handResult = await hand.GetOneNoTrackingAsync(church.Id);

        Assert.NotNull(handResult);
        Assert.Equal(handResult.Data.Id, church.Id);
        Assert.Equal(handResult.Data.Name, church.Name);
    }

    [Fact(DisplayName = nameof(GetOneChurch))]
    [Trait("Domain", "Church - GetOneChurch")]
    public async void GetOneChurch()
    {
        IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();
        DataContext context = _fixture.GetContext();
        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);
        
        Church church = _fixture.GetValidEntitie();
        await context.Churches.AddAsync(church);
        await context.SaveChangesAsync();

        Church newChurch = await hand.GetOneChurch(church.Id);
        
        Assert.NotNull(newChurch);
        Assert.Equal(newChurch.Id, church.Id);
        Assert.Equal(newChurch.Name, church.Name);
    }

    [Fact(DisplayName = nameof(GetOneByIdNotFound))]
    [Trait("Domain", "Church - GetOneByIdNotFound")]
    public async void GetOneByIdNotFound()
    {
        IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();
        DataContext context = _fixture.GetContext();
        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);

        Church church = _fixture.GetValidEntitie();
        await context.Churches.AddAsync(church);
        await context.SaveChangesAsync();

        int newId = 0;
        do {
            newId = new Random().Next(0, 101);
        }while(newId == church.Id);

        dynamic handResult = await hand.GetOneNoTrackingAsync(newId);

        Assert.Null(handResult.Data);
        Assert.NotNull(handResult.Errors);
        Assert.True(handResult.Errors.Contains("Object not found"));
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

        _ = await hand.Update(churchAddress, church.Id);
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

    [Theory(DisplayName = nameof(InvalidChurchNames))]
    [Trait("Domain", "Church - create-invalidChurchName")]
    [MemberData(nameof(BuildInvalidChurchEntitie))]
    public async Task InvalidChurchNames(ChurchAddress churchAddress, string messageErrorExpected)
    {
        IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();

        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);
        dynamic handResult = await hand.Create(churchAddress);

        Assert.Null(handResult.Data);
        Assert.True(handResult.Errors.Count > 0);
        Assert.True(handResult.Errors.Contains(messageErrorExpected));
    }

    [Theory(DisplayName = nameof(InvalidAddressProperties))]
    [Trait("Domain", "Church - create-invalidAddressProperties")]
    [MemberData(nameof(BuildInvalidAddressEntitie))]
    public async Task InvalidAddressProperties(ChurchAddress churchAddress, string messageErrorExpected)
    {
        IChurchRepository repository = _fixture.GetRepository();
        IMapper mapper = _fixture.GetMapper();

        ChurchHandler hand = new ChurchHandler(repository, mapper, _viewModel, _mockLogger.Object);
        dynamic handResult = await hand.Create(churchAddress);

        Assert.Null(handResult.Data);
        Assert.True(handResult.Errors.Count > 0);
        Assert.True(handResult.Errors.Contains(messageErrorExpected));
    }

    public static IEnumerable<object[]> BuildInvalidChurchEntitie()
    {
        Dictionary<int, string> dicObjetcts = new Dictionary<int, string>
        {
            { 1, "Name should have no more than 50 chars" },
            { 2, "Name should have at least 5 chars" },
            { 3, "Acronym should have at least 3 chars" }
        };

        ChurchBuilders newFixture = new ChurchBuilders();
        for (int i = 0; i < 3; i++)
        {
            ChurchAddress churchAddress = newFixture.GetValidChurchAddress();

            if (i == 0)
            {
                churchAddress.EditChurchDto.Name = newFixture.GetValidCode(55);
            }
            else if (i == 1)
            {
                churchAddress.EditChurchDto.Name = newFixture.GetValidCode(4);
            }
            else if (i == 2)
            {
                churchAddress.EditChurchDto.Acronym = newFixture.GetValidCode(1);
            }

            yield return new object[] { churchAddress, dicObjetcts[i + 1] };
        }
    }
    public static IEnumerable<object[]> BuildInvalidAddressEntitie()
    {
        var errorMessages = new Dictionary<int, string>
        {
            { 1, "Country should have at least 4 chars" },
            { 2, "Country should have no more than 60 chars" },
            { 3, "State should have at least 1 chars" },
            { 4, "State should have no more than 60 chars" },
            { 5, "City should have at least 4 chars" },
            { 6, "City should have no more than 60 chars" },
            { 7, "District should have at least 4 chars" },
            { 8, "District should have no more than 30 chars" },
            { 9, "Street should have at least 4 chars" },
            { 10, "Street should have no more than 60 chars" }
        };

        (int Index, Action<ChurchAddress, ChurchBuilders> Modifier)[] testCases =
        [
            (1, (address, builder) => address.EditAddressDto.Country = builder.GetValidCode(2)),
            (2, (address, builder) => address.EditAddressDto.Country = builder.GetValidParagraph(80)),
            (3, (address, builder) => address.EditAddressDto.State = string.Empty),
            (4, (address, builder) => address.EditAddressDto.State = builder.GetValidParagraph(60)),
            (5, (address, builder) => address.EditAddressDto.City = builder.GetValidCode(1)),
            (6, (address, builder) => address.EditAddressDto.City = builder.GetValidParagraph(60)),
            (7, (address, builder) => address.EditAddressDto.District = builder.GetValidCode(1)),
            (8, (address, builder) => address.EditAddressDto.District = builder.GetValidParagraph(30)),
            (9, (address, builder) => address.EditAddressDto.Street = builder.GetValidCode(1)),
            (10, (address, builder) => address.EditAddressDto.Street = builder.GetValidCode(60))
        ];

        var builder = new ChurchBuilders();
        foreach (var (index, modifier) in testCases)
        {
            var churchAddress = builder.GetValidChurchAddress();

            modifier(churchAddress, builder);

            yield return new object[] { churchAddress, errorMessages[index] };
        }
    }

    public void Dispose() =>
        _fixture.ClearContext();
}