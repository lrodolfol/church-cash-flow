namespace DataModelChurchCashFlow.Models.Entities;
public class Church : Entitie
{
    public string Name { get; private set; }
    public int AddressId { get; private set; }
    public string Acronym { get; private set; }
    public Address Address { get; private set; }


    public IList<User> Users { get; private set; }
    public IList<Member> Members { get; private set; }
    public IList<OutFlow> OutFlows { get; private set; }

    public Church(int id, string name, int addressId, string acronym)
    {
        Id = id;
        Name = name;
        AddressId = addressId;
        Acronym = acronym.ToUpper();
    }

    public void AddAddress(Address address)
    {
        Address = address;
    }

    public void UpdateChanges(Church church)
    {
        Name = church.Name;
        Active = church.Active;
    }

}
