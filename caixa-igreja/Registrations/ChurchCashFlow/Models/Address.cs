namespace ChurchCashFlow.Models;
public class Address
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string ?District { get; set; }
    public string ?Street { get; set; }
    public string ?Additional { get; set; }
    public int Number { get; set; }
    //public int ChurchId { get; set; }
    public Church Church { get; set; }
}