using Entitie = Registration.DomainBase.Entities;

namespace Registration.Mapper.DTOs.Registration.Church;
public class ReadChurchDto : ModelDto
{
    public string? Name { get; set; }
    public string? Acronym { get; set; }
    public string? FirstTreasurer { get; set; }
    public string? SecondTreasurer { get; set; }
    public string? FirstSecretary { get; set; }
    public string? SecondSecretary { get; set; }
    public string? FirstPastor { get; set; }
    public string? SecondPastor { get; set; }

    public int FirstTreasurerId { get; set; }
    public int SecondTreasurerId { get; set; }
    public int FirstSecretaryId { get; set; }
    public int SecondSecretaryId { get; set; }
    public int FirstPastorId { get; set; }
    public int SecondPastorId { get; set; }

    public Entitie.Registrations.Address? Address { get; set; }

}
