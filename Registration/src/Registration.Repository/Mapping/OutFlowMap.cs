using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Mapping;
public class OutFlowMap : IEntityTypeConfiguration<OutFlow>
{
    public void Configure(EntityTypeBuilder<OutFlow> builder)
    {
        builder.ToTable("OutFlow");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.Day)
            .IsRequired()
            .HasColumnName("Day")
            .HasColumnType("DATE");

        builder.Property(x => x.MonthYear)
            .IsRequired()
            .HasColumnName("MonthYear")
            .HasColumnType("VARCHAR")
            .HasMaxLength(7);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("VARCHAR")
            .HasMaxLength(75);

        builder.Property(x => x.Authorized)
            .IsRequired()
            .HasColumnName("Authorized")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.Amount)
            .IsRequired()
            .HasColumnName("Amount")
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.Interest)
            .HasColumnName("Interest")
            .HasColumnType("decimal(10,2)")
            .HasDefaultValue(0);

        builder.Property(x => x.Discount)
            .IsRequired()
            .HasColumnName("Discount")
            .HasColumnType("decimal(10,2)")
            .HasDefaultValue(0);

        builder.Property(x => x.TotalAmount)
            .IsRequired()
            .HasColumnName("TotalAmount")
            .HasColumnType("decimal(10,2)");

        builder.HasOne(outFlow => outFlow.OutFlowKind)
            .WithMany(kind => kind.OutFlows)
            .HasConstraintName("Fk_OutFlowKind-OutFlow")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(outFlow => outFlow.Church)
            .WithMany(church => church.OutFlows)
            .HasConstraintName("Fk_OutFlow-Church")
            .OnDelete(DeleteBehavior.NoAction);

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<OutFlow> builder)
    {
        var outFlows = new List<OutFlow>();
        outFlows.Add(new OutFlow(1, DateTime.UtcNow, DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(2, DateTime.UtcNow, DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(3, DateTime.UtcNow, DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));

        outFlows.ForEach(outF =>
        {
            builder.HasData(outF);
        });
    }
}
