namespace Registration.DomainBase.Entities.Registrations;
public class Church : Entitie
{
    public string? Name { get; private set; }
    public string? Acronym { get; private set; }
    public int AddressId { get; private set; }

    public int? FirstPastorId { get; set; } = null;
    public int? SecondPastorId { get; set; } = null;
    public int? FirstSecretaryId { get; set; } = null;
    public int? SecondSecretaryId { get; set; } = null;
    public int? FirstTreasurerId { get; set; } = null;
    public int? SecondTreasurerId { get; set; } = null;

    public Member FirstPastor { get; set; }
    public Member SecondPastor { get; set; }
    public Member FirstSecretary { get; set; }
    public Member SecondSecretary { get; set; }
    public Member FirstTreasuser { get; set; }
    public Member SecondTreasuser { get; set; }

    public Address? Address { get; private set; }
    public DateTime RegisterDate { get; private set; }
    public DateTime InaugurationDate { get; private set; }
    public List<User>? Users { get; private set; }
    public List<Member>? Members { get; private set; }
    public List<OutFlow>? OutFlows { get; private set; }
    public List<Offering>? Offerings { get; private set; }
    public List<Tithes>? Tithes { get; private set; }
    public List<FirstFruits>? FirstFruits { get; private set; }
    public List<MonthWork>? MonthWorks { get; private set; }

    public Church()
    {
        
    }
    public Church(int id, string name, DateTime registerDate, DateTime inaugurationDate, int addressId, string acronym)
    {
        Id = id;
        Name = name;
        RegisterDate = registerDate;
        InaugurationDate = inaugurationDate;
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
        Acronym = church.Acronym;
        InaugurationDate = church.InaugurationDate;
        RegisterDate = church.RegisterDate;
        FirstPastorId = church.FirstPastorId == 0 ? null : church.FirstPastorId;
        SecondPastorId = church.SecondPastorId == 0 ? null : church.SecondPastorId;
        FirstSecretaryId = church.FirstSecretaryId == 0 ? null : church.FirstSecretaryId;
        SecondSecretaryId = church.SecondSecretaryId == 0 ? null : church.SecondSecretaryId;
        FirstTreasurerId = church.FirstTreasurerId == 0 ? null : church.FirstTreasurerId;
        SecondTreasurerId = church.SecondTreasurerId == 0 ? null : church.SecondTreasurerId;
    }

}
