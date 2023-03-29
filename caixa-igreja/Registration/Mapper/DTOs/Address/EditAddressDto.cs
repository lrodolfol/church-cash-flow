using Flunt.Notifications;
using Flunt.Validations;
using Registration.DomainCore.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace Registration.Mapper.DTOs.Address;
public class EditAddressDto : ModelDto
{
    [Required]
    public string Country { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string ZipCode { get; set; }
    [Required]
    public string? District { get; set; }
    [Required]
    public string? Street { get; set; }
    public string? Additional { get; set; }
    [Required]
    public int Number { get; set; }

    public EditAddressDto(string country, string state, string city, string zipCode, string? district, string? street, string? additional, int number)
    {
        Country = country;
        State = state;
        City = city;
        ZipCode = zipCode;
        District = district;
        Street = street;
        Additional = additional;
        Number = number;
    }

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
                .IsLowerThan(Country, 3, "Country", "Country should have at least 4 chars")
                .IsGreaterThan(Country, 60, "Country", "Country should have no more than 60 chars")
                .IsLowerThan(State, 3, "State", "State should have at least 4 chars")
                .IsGreaterThan(State, 60, "State", "State should have no more than 60 chars")
                .IsLowerThan(City, 3, "City", "City should have at least 4 chars")
                .IsGreaterThan(City, 60, "City", "City should have no more than 60 chars")
                .IsLowerThan(District, 3, "District", "District should have at least 4 chars")
                .IsGreaterThan(District, 30, "District", "District should have no more than 30 chars")
                .IsLowerThan(Street, 3, "Street", "Street should have at least 4 chars")
                .IsGreaterThan(Street, 60, "Street", "Street should have no more than 60 chars")
                .IsNull(Number,"Number","Number cannot be empty or zero")
                .IsLowerThan(Number, 0, "Number cannot be empty or zero")
            );
    }
}
