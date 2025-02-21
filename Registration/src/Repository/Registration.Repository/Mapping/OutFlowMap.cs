using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class OutFlowMap : IEntityTypeConfiguration<OutFlow>
{
    public void Configure(EntityTypeBuilder<OutFlow> builder)
    {
        builder.ToTable("OutFlow");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.Day)
            .IsRequired()
            .HasColumnName("Day")
            .HasColumnType("DATE");

        builder.Property(x => x.Competence)
            .IsRequired()
            .HasColumnName("Competence")
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
        outFlows.Add(new OutFlow(1, DateTime.UtcNow.AddDays(-10), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(2, DateTime.UtcNow.AddDays(-15), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(3, DateTime.UtcNow.AddDays(-20), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));
        outFlows.Add(new OutFlow(4, DateTime.UtcNow.AddDays(-25), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(5, DateTime.UtcNow.AddDays(-30), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(6, DateTime.UtcNow.AddDays(-35), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));
        outFlows.Add(new OutFlow(7, DateTime.UtcNow.AddDays(-40), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(8, DateTime.UtcNow.AddDays(-45), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(9, DateTime.UtcNow.AddDays(-50), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));
        outFlows.Add(new OutFlow(10, DateTime.UtcNow.AddDays(-55), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(11, DateTime.UtcNow.AddDays(-60), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(12, DateTime.UtcNow.AddDays(-65), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));
        outFlows.Add(new OutFlow(13, DateTime.UtcNow.AddDays(-70), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(14, DateTime.UtcNow.AddDays(-75), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(15, DateTime.UtcNow.AddDays(-80), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));
        outFlows.Add(new OutFlow(16, DateTime.UtcNow.AddDays(-85), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(17, DateTime.UtcNow.AddDays(-90), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(18, DateTime.UtcNow.AddDays(-98), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));
        outFlows.Add(new OutFlow(19, DateTime.UtcNow.AddDays(-100), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(20, DateTime.UtcNow.AddDays(-10), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(21, DateTime.UtcNow.AddDays(-18), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));
        outFlows.Add(new OutFlow(22, DateTime.UtcNow.AddDays(-19), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(23, DateTime.UtcNow.AddDays(-20), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(24, DateTime.UtcNow.AddDays(-23), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));
        outFlows.Add(new OutFlow(25, DateTime.UtcNow.AddDays(-15), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 1", 1, 1, 100m, 2m, 0m));
        outFlows.Add(new OutFlow(26, DateTime.UtcNow.AddDays(-20), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 2", 2, 2, 1000.01m, 1.56m, 0m));
        outFlows.Add(new OutFlow(27, DateTime.UtcNow.AddDays(-30), DateTime.UtcNow.ToString("MM/yyyy"), "Saida de caixa 3", 3, 3, 1500.56m, 0.6m, 20m));


        outFlows.ForEach(outF =>
        {
            outF.CalculateTotalAmount();

            builder.HasData(outF);
        });
    }
}
