using Bogus;

namespace Registration.UnitTest.Shared.Builders.Entities;
public class BaseBuilderEntitie
{
    public Faker Faker {  get; set; }
    public BaseBuilderEntitie() => Faker = new Faker(nameof(BogusLocaleEnum.pt_BR));
    public bool GetRandomBoolean() => 
        new Random().NextDouble() < 0.5;
    public int GetRandomInt() =>
        new Random().Next(0, 10_001);
    public decimal GetRandomDecimal() =>
        (decimal)new Random().NextDouble();
    public string GetValidPersonShortName() =>
        Faker.Person.FirstName;
    public string GetValidPersonFullNameName() =>
        Faker.Person.FullName;
    public DateTime GetValidNearDate() =>
        Faker.Date.Between(
            new DateTime(DateTime.Now.Year, 1, 1), 
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(-1).Day)
            );
    public DateTime GetValidBeforeDate() =>
    Faker.Date.Between(
        new DateTime(DateTime.Now.AddYears(-50).Year, 1, 1),
        new DateTime(DateTime.Now.AddYears(-20).Year, DateTime.Now.Month, DateTime.Now.AddDays(-1).Day)
        );
    public string GetValidDescription() =>
        Faker.Commerce.ProductDescription();
    public string GetValidCode(int lenght = 6) =>
        Faker.Random.AlphaNumeric(lenght);
}
