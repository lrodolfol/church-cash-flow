namespace Registration.DomainBase.Entities.Registrations;
public class Member : Entitie
{
    private void GenerateCode()
    {
        var code = $"{Church!.Acronym}-{CreateGuid(6)}";
        Code = code;
    }

    public string? Code { get; private set; }
    public string? Name { get; private set; }
    public string? Photo { get; private set; }
    public string? Description { get; private set; }
    public DateTime DateBirth { get; private set; }
    public DateTime DateRegister { get; private set; }
    public DateTime DateBaptism { get; private set; }
    public int ChurchId { get; private set; }

    public List<MemberPost> MemberPost { get; private set; }
    public Church? Church { get; private set; }
    //public Church? ChurchFirstPastor { get; private set; }
    public List<Offering>? Offerings { get; private set; }
    public List<Tithes>? Tithes { get; private set; }
    public List<FirstFruits>? FirstFruits { get; private set; }
    public MemberOut? MemberOut { get; private set; }
    public MemberIn? MemberIn { get; private set; }

    public Member()
    {        
    }

    public Member(int id, string name, DateTime dateBirth, DateTime dateBaptism, int churchId, string code, DateTime dateRegister)
    {
        Id = id;
        Name = name;
        DateBirth = dateBirth;
        ChurchId = churchId;
        Code = code;
        DateBaptism = dateBaptism;
        DateRegister = dateRegister;
    }

    public void UpdateChanges(Member member)
    {
        Name = member.Name;
        DateBirth = member.DateBirth;
        ChurchId = member.ChurchId;
        Description = member.Description;
        DateBaptism = member.DateBaptism;
        DateRegister = member.DateRegister;
    }
    public void AddChurch(Church church)
    {
        Church = church;
    }
    public void UpdateData()
    {
        GenerateCode();
    }
    public void SetPhoto()
    {
        Photo = $"/{Code}";
    }
}
