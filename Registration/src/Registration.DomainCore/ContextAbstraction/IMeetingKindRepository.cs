using Registration.DomainBase.Entities.Registrations;

namespace Registration.DomainCore.ContextAbstraction;
public interface IMeetingKindRepository
{
    public IQueryable<MeetingKind>? GetAll();
    public Task<MeetingKind> GetOne(int id);
    public Task<MeetingKind> GetOneAsNoTracking(int id);
    public Task Post(MeetingKind meetingKind);
    public Task Delete(MeetingKind meetingKind);
}