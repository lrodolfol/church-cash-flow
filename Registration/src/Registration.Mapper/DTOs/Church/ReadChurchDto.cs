using Entitie = Registration.DomainBase.Entities;

namespace Registration.Mapper.DTOs.Church;
public class ReadChurchDto : ModelDto
{
    public string? Name { get; set; }
    public string? Acronym { get; set; }
    public Entitie.Address? Address { get; set; }
}
