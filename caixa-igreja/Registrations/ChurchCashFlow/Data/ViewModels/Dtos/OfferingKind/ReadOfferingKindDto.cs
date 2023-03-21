using Flunt.Notifications;
using System.Diagnostics.Contracts;

namespace ChurchCashFlow.Data.ViewModels.Dtos.OfferingKind;
public class ReadOfferingKindDto : ModelDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}