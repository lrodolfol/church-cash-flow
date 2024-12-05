using Registration.DomainBase.Entities.Registrations.Bible;
using Registration.Mapper.DTOs.Registration.Bible;

namespace Registration.DomainCore.ContextAbstraction;
public interface IBibleRepository
{
    Task<List<Verse>> GetAsync(GetBibleDto dto);
}
