using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Entities;

namespace RegistrationTest.ContextFake;
public class ChurchContextFake : IChurchContext
{
	private List<Church> Churches { get; set; }
	private List<Address> Addresses { get; set; } = new();
	public ChurchContextFake()
	{
		Addresses.Add(new Address
		{
			Id = Addresses.Count() + 1,
			Country = "Brasil",
			State = "Minas Gerais",
			City = "São Lourenço",
			ZipCode = "37470-000",
			District = "Vila Nova",
			Street = "Av. Juscelino Kubchk",
			Additional = "",
			Number = 381
		});

        Churches.Add(new Church(1, "CEO São Lourenço", Addresses.First().Id));
	}

    public IQueryable<Church>? GetAll(bool active)
    {
        throw new NotImplementedException();
    }

    public Task<Church> GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Church> GetOneNoTracking(int id)
    {
        throw new NotImplementedException();
    }

    public Task Post(Church church)
    {
        throw new NotImplementedException();
    }

    public Task Put(Church church)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Church church)
    {
        throw new NotImplementedException();
    }
}
