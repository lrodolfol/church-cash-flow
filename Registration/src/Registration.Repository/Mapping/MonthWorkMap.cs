using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Mapping;
public class MonthWorkMap : IEntityTypeConfiguration<MonthWork>
{
    public void Configure(EntityTypeBuilder<MonthWork> builder)
    {
        builder.ToTable("MonthWork");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.YearMonth)
            .IsRequired()
            .HasColumnName("YearMonth")
            .HasColumnType("INT");

        builder.Property(x => x.Block)
            .IsRequired()
            .HasColumnName("Block")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.ChurchId)
            .IsRequired()
            .HasColumnName("ChurchId")
            .HasColumnType("INT");

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
            new MonthWork(1, 202301, true, 1),
            new MonthWork(2, 202302, true, 1),
            new MonthWork(3, 202303, true, 1)
        };

        monthsWork.ForEach(x =>
        {
            builder.HasData(x);
        });

    }
}
