using Registration.DomainBase.Entities.Registrations;

namespace Registration.UnitTest.Shared.Builders.Entities;
public class AddressBuilder : BaseBuilderEntitie
{
    public Address Get => GetValid();
    private Address GetValid() =>
        new Address(GetRandomInt(),
            GetValidCountryName(),
            GetValidStateName(),
            GetValidCityName(),
            GetValidZipCode(),
            GetValidDistrict(),
            GetValidStreet(),
            GetValidAdditional(),
            GetRandomInt());

    private string GetValidCountryName() =>
        Faker.Address.Country();
    private string GetValidStateName() =>
        Faker.Address.State();
    private string GetValidCityName() =>
        Faker.Address.City();
    private string GetValidZipCode() =>
        Faker.Address.ZipCode();
    private string GetValidDistrict() =>
        Faker.Address.Direction();
    private string GetValidStreet() =>
        Faker.Address.StreetName();
    private string GetValidAdditional() =>
        Faker.Address.SecondaryAddress();
}
