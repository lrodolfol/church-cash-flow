using ChurchCashFlow.Data.Mappings;
using ChurchCashFlow.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChurchCashFlow.Data.Context;
public class DataContext : ModelContext
{
    public DataContext(DbContextOptions<DataContext> opt) : base(opt){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AddressMap());
        modelBuilder.ApplyConfiguration(new ChurchMap());
        modelBuilder.ApplyConfiguration(new UserMap());
        modelBuilder.ApplyConfiguration(new RoleMap());
    }
}
