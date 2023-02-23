namespace ChurchCashFlow.Data.Entities;
public class User
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string PassWordHash { get; set; }
    public bool? Active { get; set; }
    public int ChurchId { get; set; }
    public int RoleId { get; set; }
    public Church Church { get; set; }
    public Role Role { get; set; }
}