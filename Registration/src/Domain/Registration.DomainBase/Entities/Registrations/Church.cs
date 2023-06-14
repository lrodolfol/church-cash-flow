namespace Registration.DomainBase.Entities.Registrations;
public class Church : Entitie
{
    public string? Name { get; private set; }
    public string? Acronym { get; private set; }
    public int AddressId { get; private set; }
    public int FirstTreasurerId { get; set; }
    public int SecondTreasurerId { get; set; }
    public int FirstSecretaryId { get; set; }
    public int SecondSecretaryId { get; set; }
    public int FirstPastorId { get; set; }
    public int SecondPastorId { get; set; }


    public Address? Address { get; private set; }
    public Member? FirstTreasurer { get; set; }
    public Member? SecondTreasurer { get; set; }
    public Member? FirstSecretary { get; set; }
    public Member? SecondSecretary { get; set; }
    public Member? FirstPastor { get; set; }
    public Member? SecondPastor { get; set; }


    public List<User>? Users { get; private set; }
    public List<Member>? Members { get; private set; }
    public List<OutFlow>? OutFlows { get; private set; }
    public List<Offering>? Offerings { get; private set; }
    public List<Tithes>? Tithes { get; private set; }
    public List<FirstFruits>? FirstFruits { get; private set; }
    public List<MonthWork>? MonthWorks { get; private set; }

    public Church(int id, string name, int addressId, string acronym, 
        int firstTreasurerId, int secondTreasurerId, int firstSecretaryId, 
        int secondSecretaryId, int firstPastorId, int secondPastorId)
    {
        Id = id;
        Name = name;
        AddressId = addressId;
        FirstTreasurerId = firstTreasurerId;
        SecondTreasurerId = secondTreasurerId;
        FirstSecretaryId = firstSecretaryId;
        SecondSecretaryId = secondSecretaryId;
        FirstPastorId = firstPastorId;
        SecondPastorId = secondPastorId;

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
