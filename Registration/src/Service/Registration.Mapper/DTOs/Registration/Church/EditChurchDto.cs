using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;

namespace Registration.Mapper.DTOs.Registration.Church;
public class EditChurchDto : ModelDto
{
    [Required(ErrorMessage = "The name is required")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "The size must be between 5 and 50 characters")]
    public string Name { get; set; }
    public string Acronym { get; set; }
    public int FirstTreasurerId { get; set; }
    public int SecondTreasurerId { get; set; }
    public int FirstSecretaryId { get; set; }
    public int SecondSecretaryId { get; set; }
    public int FirstPastorId { get; set; }
    public int SecondPastorId { get; set; }

    public EditChurchDto(string name, string acronym, int firstTreasurerId,
        int secondTreasurerId, int firstSecretaryId, int secondSecretaryId,
        int firstPastorId, int secondPastorId)
    {
        Name = name;
        Active = true;
        Acronym = acronym.ToUpper();
        FirstTreasurerId = firstTreasurerId;
        SecondTreasurerId = secondTreasurerId;
        FirstSecretaryId = firstSecretaryId;
        SecondSecretaryId = secondSecretaryId;
        FirstPastorId = firstPastorId;
        SecondPastorId = secondPastorId;
    }

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsLowerThan(Name, 50, "Name", "Name should have no more than 5 chars")
            .IsGreaterThan(Name, 5, "Name", "Name should have at least 50 chars")
            .IsGreaterThan(Name, 2, "Name", "Acronym should have at least 3 chars")
        );
    }
}
