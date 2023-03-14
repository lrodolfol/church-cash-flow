using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Entities;
using System.Reflection.Metadata.Ecma335;

namespace RegistrationTest.ContextFake;
public class ChurchContextFake : IChurchContext
{
    public static List<Church> Churches { get; private set; } = new();
	public static List<Address> Adresses { get; private set; } = new();
	public ChurchContextFake()
	{
		Adresses.Add(new Address
		{
			Id = Adresses.Count() + 1,
			Country = "Brasil",
			State = "Minas Gerais",
			City = "São Lourenço",
			ZipCode = "37470-000",
			District = "Vila Nova",
			Street = "Av. Juscelino Kubchk",
			Additional = "",
			Number = 381
		});
        Adresses.Add(new Address
        {
            Id = Adresses.Count() + 1,
            Country = "Brasil",
            State = "Minas Gerais",
            City = "Lambari",
            ZipCode = "37480-000",
            District = "Centro",
            Street = "Praça Vivaldi Leite",
            Additional = "Hotel Itaici",
            Number = 181
        });

        Churches.Add(new Church(1, "CEO São Lourenço", Adresses.First().Id));
        Churches.Add(new Church(1, "CEO Lambari", Adresses.First().Id + 1));
    }

    public IQueryable<Church>? GetAll(bool active)
    {
        throw new NotImplementedException();
    }

    public async Task<Church> GetOne(int id)
    {
        var church = Churches.FirstOrDefault(x => x.Id == id);
        church.Address = Adresses.Find(x => x.Id == church.AddressId);

        return church;
    }

    public async Task<Church> GetOneNoTracking(int id) => Churches.FirstOrDefault(x => x.Id == id);

    public async Task Post(Church church)
    {
        Churches.Add(church);
    }

    public async Task Put(Church church)
    {
    }

    public Task Delete(Church church)
    {
        throw new NotImplementedException();
    }
}
