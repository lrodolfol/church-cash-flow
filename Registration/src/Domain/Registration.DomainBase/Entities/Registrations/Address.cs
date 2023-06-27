namespace Registration.DomainBase.Entities.Registrations;
public class Address
{
    public int Id { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? District { get; set; }
    public string? Street { get; set; }
    public string? Additional { get; set; }
    public int Number { get; set; }

    public void UpdateChanges(Address editAddress)
    {
        Country = editAddress.Country;
        State = editAddress.State;
        City = editAddress.City;
        ZipCode = editAddress.ZipCode;
        District = editAddress.District;
        Street = editAddress.Street;
        Additional = editAddress.Additional;
        Number = editAddress.Number;
    }

    public Address()
    {
    }

    public Address(int id, string? country, string? state, string? city, string? zipCode, string? district, string? street, string? additional, int number)
    {
        Id = id;
        Country = country;
        State = state;
        City = city;
        ZipCode = zipCode;
        District = district;
        Street = street;
        Additional = additional;
        Number = number;
    }
}