namespace ChurchCashFlow.Data.Entities;
public class Church
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool? Active { get; set; }
    public int AddressId { get; set; }
    public Address Address { get; set; }

    public IList<User> Users { get; set; }

    public void AddAddress(Address address)
    {
        Address= address;
    }

    public void Activate(bool active)
    {
        Active = active;
    }
}