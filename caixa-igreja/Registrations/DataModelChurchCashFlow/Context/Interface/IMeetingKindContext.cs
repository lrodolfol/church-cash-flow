using DataModelChurchCashFlow.Models.Entities;

namespace DataModelChurchCashFlow.Context.Interface;
public interface IMeetingKindContext
{
    public IQueryable<MeetingKind>? GetAll();
    public Task<MeetingKind> GetOne(int id);
    public Task<MeetingKind> GetOneAsNoTracking(int id);
    public Task Post(MeetingKind meetingKind);
    public Task Delete(MeetingKind meetingKind);
}