namespace Registration.DomainBase.Entities;
public class Church : Entitie
{
    public string? Name { get; private set; }
    public int AddressId { get; private set; }
    public string? Acronym { get; private set; }
    public Address? Address { get; private set; }


    public List<User>? Users { get; private set; }
    public List<Member>? Members { get; private set; }
    public List<OutFlow>? OutFlows { get; private set; }
    public List<Offering>? Offerings { get; private set; }
    public List<Tithes>? Tithes { get; private set; }
    public List<FirstFruits>? FirstFruits { get; private set; }
    public List<MonthWork>? MonthWorks { get; private set; }

    public Church(int id, string name, int addressId, string acronym)
    {
        Id = id;
        Name = name;
        AddressId = addressId;
        Acronym = acronym.ToUpper();
    }
    public Church()
    {
    }

    public void AddAddress(Address address)
    {
        Address = address;
    }

    public void UpdateChanges(Church church)
    {
        Name = church.Name;
        Active = church.Active;
        Acronym = church.Acronym;
    }

}
