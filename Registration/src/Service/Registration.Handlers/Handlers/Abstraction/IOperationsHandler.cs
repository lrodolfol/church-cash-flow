using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Registration.MonthWork;

namespace Registration.Handlers.Handlers.Abstraction;
public interface IOperationsHandler
{
    Task<CViewModel> BlockMonthWork(EditMonthWorkDto editMonthYorkDto);
    Task<CViewModel> UnblockMonthWork(int id);
    Task<CViewModel> GetByChurchByYear(int churchId, int year);
    Task<CViewModel> GetAllByYear(int year);
    Task<CViewModel> GetAll(int churchId);
    Task<MonthWork> GetOneByCompetence(string yearMonth, int churchId);
}
