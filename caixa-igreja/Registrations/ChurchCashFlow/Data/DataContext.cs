using ChurchCashFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace ChurchCashFlow.Data;
public class DataContext : DbContext
{
    public DbSet<Church> Churches { get; set; }
    public DbSet<Address> Adresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=ChuchCashFlow;TrustServerCertificate=True;User ID=sa;Password=#Sinqia12");
}
