using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Registration.Repository;
using Registration.UnitTest.Shared;

namespace Registration.UnitTest.Test.Builders;
public class BaseBuilder
{
    public Faker Faker { get; set; }
    public IServiceProvider ServiceProvider { get; protected set; }
    public ServiceCollection ServiceCollection { get; protected set; }
    public BaseBuilder()
    {
        LoadFaker();
    }
    private void LoadFaker() =>
        Faker = new Faker(nameof(BogusLocaleEnum.pt_BR));
    protected void BuilderDataContext()
    {
        var randDataBaseName = Guid.NewGuid().ToString().Substring(0, 8);
        ServiceCollection = new ServiceCollection();

        ServiceCollection.AddDbContext<DataContext>(options =>
        {
            options.UseInMemoryDatabase(randDataBaseName);
        });
    }
    protected bool GetRandomBoolean() =>
    new Random().NextDouble() < 0.5;
    protected int GetRandomInt() =>
        new Random().Next(0, 10_001);
    protected decimal GetRandomDecimal() =>
        (decimal)new Random().NextDouble();
    protected string GetValidPersonShortName() =>
        Faker.Person.FirstName;
    protected string GetValidPersonFullNameName() =>
        Faker.Person.FullName;
    protected DateTime GetValidNearDate() =>
        Faker.Date.Between(
            new DateTime(DateTime.Now.Year, 1, 1),
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(-1).Day)
            );
    protected DateTime GetValidBeforeDate() =>
    Faker.Date.Between(
        new DateTime(DateTime.Now.AddYears(-50).Year, 1, 1),
        new DateTime(DateTime.Now.AddYears(-20).Year, DateTime.Now.Month, DateTime.Now.AddDays(-1).Day)
        );
    protected string GetValidDescription() =>
        Faker.Commerce.ProductDescription();
    public string GetValidCode(int lenght = 6) =>
        Faker.Random.AlphaNumeric(lenght);
    public DataContext GetContext() =>
        ServiceProvider.GetRequiredService<DataContext>();
    public void ClearContext() =>
        ServiceProvider.GetRequiredService<DataContext>().Database.EnsureDeleted();
    public string GetValidParagraph(int numberOfSetences = 3) =>
        Faker.Lorem.Paragraph(numberOfSetences);
    internal void ReloadFaker() =>
        LoadFaker();

}
