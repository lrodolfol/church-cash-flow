using ChurchCashFlow.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChurchCashFlow.Data.Context;
public abstract class ModelContext : DbContext
{
    public DbSet<Church> Churches { get; set; }
    public DbSet<Address> Adresses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public ModelContext(DbContextOptions<DataContext> opt) : base(opt) { }
	
}