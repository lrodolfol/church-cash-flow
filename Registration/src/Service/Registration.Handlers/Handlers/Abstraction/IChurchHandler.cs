using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Registration.ChurchAddress;

namespace Registration.Handlers.Handlers.Abstraction;
public interface IChurchHandler
{
    Task<CViewModel> GetAll(bool active = true);
    Task<CViewModel> GetOneNoTrackingAsync(int id);
    Task<Church> GetOneChurch(int id);
    Task<CViewModel> Create(ChurchAddress churchEditDto);
    Task<CViewModel> Update(ChurchAddress churchEditDto, int id);
    Task<CViewModel> Delete(int id);
    Task<CViewModel> GetMembers(IMemberRepository memberContext, int churchId);
    Task<CViewModel> GetMembersByMonth(IMemberRepository memberContext, int churchId, string yearMonth);
    Task<CViewModel> GetChurchByPeriod(string initialDate, string finalDate, bool active);
}
}
