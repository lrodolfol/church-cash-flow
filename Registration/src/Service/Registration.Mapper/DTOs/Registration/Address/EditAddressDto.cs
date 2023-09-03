using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;

namespace Registration.Mapper.DTOs.Registration.Address;
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
                .IsGreaterThan(Country, 3, "Country", "Country should have at least 4 chars")
                .IsLowerThan(Country, 60, "Country", "Country should have no more than 60 chars")
                .IsGreaterThan(State, 3, "State", "State should have at least 4 chars")
                .IsLowerThan(State, 60, "State", "State should have no more than 60 chars")
                .IsGreaterThan(City, 3, "City", "City should have at least 4 chars")
                .IsLowerThan(City, 60, "City", "City should have no more than 60 chars")
                .IsGreaterThan(District, 3, "District", "District should have at least 4 chars")
                .IsLowerThan(District, 30, "District", "District should have no more than 30 chars")
                .IsGreaterThan(Street, 3, "Street", "Street should have at least 4 chars")
                .IsLowerThan(Street, 60, "Street", "Street should have no more than 60 chars")
                .IsNotNull(Number, "Number", "Number cannot be empty or zero")
                .IsGreaterThan(Number, 0, "Number cannot be empty or zero")
            );
    }
}
