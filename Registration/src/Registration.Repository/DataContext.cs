using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities;
using Regristration.Repository.Mapping;

namespace Regristration.Repository;
public class DataContext : DbContext
{
    public DbSet<Church> Churches { get; private set; }
    public DbSet<Address> Adresses { get; private set; }
    public DbSet<User> Users { get; private set; }
    public DbSet<Role> Roles { get; private set; }
    public DbSet<Post> Posts { get; private set; }
    public DbSet<Member> Members { get; private set; }
    public DbSet<MeetingKind> MeetingKind { get; private set; }
    public DbSet<OfferingKind> OfferingKind { get; private set; }
    public DbSet<OutFlowKind> OutFlowKind { get; private set; }
    public DbSet<OutFlow> OutFlow { get; private set; }
    public DbSet<Offering> Offering { get; private set; }
    public DbSet<Tithes> Tithes { get; private set; }
    public DbSet<FirstFruits> FirstFruits { get; private set; }
    public DbSet<MonthWork> MonthWork { get; private set; }
    //public DbSet<MonthlyClosing> MonthlyClosing { get; private set; }

    public DataContext(DbContextOptions<DataContext> opt) : base(opt)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AddressMap());
        modelBuilder.ApplyConfiguration(new ChurchMap());
        modelBuilder.ApplyConfiguration(new UserMap());
        modelBuilder.ApplyConfiguration(new RoleMap());
        modelBuilder.ApplyConfiguration(new PostMap());
        modelBuilder.ApplyConfiguration(new MemberMap());
        modelBuilder.ApplyConfiguration(new MeetingKindMap());
        modelBuilder.ApplyConfiguration(new OfferingKindMap());
        modelBuilder.ApplyConfiguration(new OutFlowKindMap());
        modelBuilder.ApplyConfiguration(new OutFlowMap());
        modelBuilder.ApplyConfiguration(new OfferingMap());
        modelBuilder.ApplyConfiguration(new TithesMap());
        modelBuilder.ApplyConfiguration(new FirstFruitsMap());
        modelBuilder.ApplyConfiguration(new MonthWorkMap());
        //modelBuilder.ApplyConfiguration(new MonthlyClosingkMap());
    }

    
}