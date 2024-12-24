using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class MonthWorkMap : IEntityTypeConfiguration<MonthWork>
{
    public void Configure(EntityTypeBuilder<MonthWork> builder)
    {
        builder.ToTable("MonthWork");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.YearMonth)
            .IsRequired()
            .HasColumnName("YearMonth")
            .HasColumnType("INT");

        builder.Property(x => x.ChurchId)
            .IsRequired()
            .HasColumnName("ChurchId")
            .HasColumnType("INT");

        builder.Property(x => x.InitialValue)
            .IsRequired()
            .HasDefaultValue(0)
            .HasColumnName("InitialValue")
            .HasColumnType("DECIMAL(10,3)");

        builder.Property(x => x.FinalValue)
            .IsRequired()
            .HasDefaultValue(0)
            .HasColumnName("FinalValue")
            .HasColumnType("DECIMAL(10,3)");

        builder.HasOne(tithes => tithes.Church)
            .WithMany(church => church.MonthWorks)
            .HasConstraintName("Fk_MonthWorks_Church")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(x => new { x.ChurchId, x.YearMonth }).IsUnique().HasName("IX_Church_YearMonth");

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<MonthWork> builder)
    {
        var monthsWork = new List<MonthWork>
        {
            new MonthWork(1, 202301, 1),
            new MonthWork(2, 202302, 1),
            new MonthWork(3, 202303, 1)
        };

        monthsWork.ForEach(x =>
        {
            builder.HasData(x);
        });

    }
}
