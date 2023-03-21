using Flunt.Notifications;
using System.Diagnostics.Contracts;

namespace ChurchCashFlow.Data.ViewModels.Dtos.MeetingKind;
public class ReadMeetingKindDto : ModelDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}