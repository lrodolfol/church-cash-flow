using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.Mapper.DTOs.Registration.Address;
using Registration.Mapper.DTOs.Registration.Church;
using Registration.Mapper.DTOs.Registration.ChurchAddress;
using Registration.Mapper.Profiles;
using Registration.Repository;
using Registration.Repository.Repository.Registration;
using Registration.Test.Shared.Builders.Mappers;

namespace Registration.UnitTest.Test.Builders;

public class ChurchBuilders : BaseBuilder
{
    public ChurchBuilders() : base()
    {
        BuilderRespository();
        BuilderMapper();

        ServiceProvider = ServiceCollection.BuildServiceProvider();
    }

    private ServiceCollection BuilderRespository()
    {
        //one repository depends other repository is a implementatio error
        ServiceCollection.AddScoped<AddressRepository>();
        ServiceCollection.AddScoped<IChurchRepository, ChurchRepository>();

        return ServiceCollection;
    }

    private ServiceCollection BuilderMapper()
    {
        ServiceCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        ServiceCollection.AddSingleton(AddressMappersBuilder.Mapper());
        ServiceCollection.AddAutoMapper(typeof(AddressProfile));

        return ServiceCollection;
    }

    public IChurchRepository GetRepository()
    {
        var context = ServiceProvider.GetRequiredService<DataContext>();
        context.Database.EnsureCreated();

        IChurchRepository respository = ServiceProvider.GetRequiredService<IChurchRepository>();
        return respository;
    }
    public Church GetValidEntitie()
    {
        Church church = new Church(GetRandomInt(),
            GetValidPersonFullNameName(),
            GetValidNearDate(),
            GetValidNearDate(),
            GetAddressEntitie().Id,
            GetValidPersonFullNameName()
            );
        church.AddAddress(GetAddressEntitie());
        church.Activate(true);

        return church;
    }
    public EditChurchDto GetValidEditDto() =>
        GetMapper().Map<EditChurchDto>(GetValidEntitie());

    public IMapper GetMapper() =>
        BaseModelMapperBuilder<Church>.Mapper();

    //churchAddress
    public ChurchAddress GetValidChurchAddress() =>
        new ChurchAddress(GetValidEditDto(), GetValidAddressEdtitDto());

    //AddressBuilders
    private Address GetAddressEntitie() =>
        new Address(GetRandomInt(),
            Faker.Address.Country(),
            Faker.Address.State(),
            Faker.Address.City(),
            Faker.Address.ZipCode(),
            Faker.Address.Direction(),
            Faker.Address.StreetName(),
            Faker.Address.SecondaryAddress(),
            GetRandomInt());
    public EditAddressDto GetValidAddressEdtitDto() =>
        GetMapper().Map<EditAddressDto>(GetAddressEntitie());
}
[CollectionDefinition(nameof(ChurchBuilders))]
public class CreateCategoryRepositoryFixtureCollection : ICollectionFixture<ChurchBuilders> { }