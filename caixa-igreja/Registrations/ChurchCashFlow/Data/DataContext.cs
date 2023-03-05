using ChurchCashFlow.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using DataModelChurchCashFlow.Entities;

namespace ChurchCashFlow.Data;
public class DataContext : DbContext
{
    public DbSet<Church> Churches { get; set; }
    public DbSet<Address> Adresses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public DataContext(DbContextOptions<DataContext> opt) : base(opt)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AddressMap());
        modelBuilder.ApplyConfiguration(new ChurchMap());
        modelBuilder.ApplyConfiguration(new UserMap());
        modelBuilder.ApplyConfiguration(new RoleMap());
    }
}
