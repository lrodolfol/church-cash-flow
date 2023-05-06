using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Registration.Mapper.DTOs.OutFlow;
public class EditOutFlowDto : ModelDto
{
    [Required]
    public DateTime Day { get; set; }
    [Required]
    public string? Competence { get; set; } //competencia (12/2023)
    public string? Description { get; set; }
    public bool Authorized { get; set; } = true;
    [Required]
    public decimal Amount { get; set; }
    public decimal Interest { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalAmount { get; set; }
    [Required]
    public int OutFlowKindId { get; set; }
    [Required]
    public int ChurchId { get; set; }

    public void Validate()
    {
        if (Day > DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")))
            AddNotification("Day", "Day cannot be greater than today");

        try
        {
            var dt = DateTime.Parse(Competence!).ToString("yyyy/MM");
            Competence = dt;
        }
        catch
        {
            AddNotification("MonthYear", "Monthly proficiency is invalid");
        }

        AddNotifications(new Contract<Notification>()
            .IsGreaterThan(Amount, 0, "Amount", "Its not possible add empty values")
            .IsGreaterThan(OutFlowKindId, 0, "OutFlowKindId", "The OutFlowKind is required")
            .IsGreaterThan(ChurchId, 0, "ChurchId", "The ChurchId is required")
            .IsGreaterOrEqualsThan(Interest, 0, "Interest cannot be negative")
            .IsGreaterOrEqualsThan(Discount, 0, "Discount cannot be negative")
            .IsNotNullOrEmpty(Description,"Description","Description cannot be empty")
            .IsLowerThan(Description, 75, "Description", "Description should between 0 and 75 characters")
            );
    }
}