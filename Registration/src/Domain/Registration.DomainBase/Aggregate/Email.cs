using System.Text.RegularExpressions;

namespace Registration.DomainBase.Aggregate;
public class Email
{
    public string Address { get; set; } = null!;

    public Email(string? address)
    {
        if(address is not null)
            Address = address;
    }
    
    public void Validate() => Regex.IsMatch(Address, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");    
}
