using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class FirstFruitsMap : IEntityTypeConfiguration<FirstFruits>
{
    public void Configure(EntityTypeBuilder<FirstFruits> builder)
    {
        builder.ToTable("FirstFruits");
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

        builder.Property(x => x.TotalAmount)
            .IsRequired()
            .HasColumnName("TotalAmount")
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("VARCHAR")
            .HasMaxLength(75);

        builder.Property(x => x.Competence)
            .IsRequired()
            .HasColumnName("Competence")
            .HasColumnType("VARCHAR")
            .HasMaxLength(8);

        builder.Property(x => x.Photo)
            .HasColumnName("Photo")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.OfferingKindId)
            .IsRequired()
            .HasColumnName("OfferingKindId")
            .HasColumnType("INT");

        builder.Property(x => x.ChurchId)
            .IsRequired()
            .HasColumnName("ChurchId")
            .HasColumnType("INT");

        builder.Property(x => x.MemberId)
            .IsRequired()
            .HasColumnName("MemberId")
            .HasColumnType("INT");

        builder.HasOne(fruits => fruits.OfferingKind)
            .WithMany(offeringK => offeringK.FirstFruits)
            .HasConstraintName("Fk_FirstFruits_Offering_Kind")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(fruits => fruits.Church)
            .WithMany(church => church.FirstFruits)
            .HasConstraintName("Fk_FirstFruits_Church")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(fruits => fruits.Member)
            .WithMany(member => member.FirstFruits)
            .HasConstraintName("Fk_FirstFruits_Member")
            .OnDelete(DeleteBehavior.NoAction);

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<FirstFruits> builder)
    {
        var firstFruitList = new List<FirstFruits>()
        {
            new FirstFruits(1, "Primicias do irmao/irma",  56.60m, DateTime.Now.AddDays(-10), "04/2023", 1, 1, 1),
            new FirstFruits(2, "Primicias do irmao / irma", 565.60m, DateTime.Now.AddDays(-15), "03 /2023", 2, 2, 2),
            new FirstFruits(3, "Primicias do irmao / irma", 156.60m, DateTime.Now.AddDays(-20), "02/2023", 1, 2, 2),
            new FirstFruits(4, "Primicias do irmao/irma",  56.60m, DateTime.Now.AddDays(-25), "04/2023", 1, 1, 1),
            new FirstFruits(5, "Primicias do irmao / irma", 565.60m, DateTime.Now.AddDays(-30), "03 /2023", 2, 2, 2),
            new FirstFruits(6, "Primicias do irmao / irma", 156.60m, DateTime.Now.AddDays(-35),   "02/2023", 1, 2, 2),
            new FirstFruits(7, "Primicias do irmao/irma",  56.60m, DateTime.Now.AddDays(-40), "04/2023", 1, 1, 1),
            new FirstFruits(8, "Primicias do irmao / irma", 565.60m, DateTime.Now.AddDays(-45), "03 /2023", 2, 2, 2),
            new FirstFruits(9, "Primicias do irmao / irma", 156.60m, DateTime.Now.AddDays(-50), "02/2023", 1, 2, 2),
            new FirstFruits(10, "Primicias do irmao/irma",  56.60m, DateTime.Now.AddDays(-60), "04/2023", 1, 1, 1),
            new FirstFruits(11, "Primicias do irmao / irma", 565.60m, DateTime.Now.AddDays(-70), "03 /2023", 2, 2, 2),
            new FirstFruits(12, "Primicias do irmao / irma", 156.60m, DateTime.Now.AddDays(-80), "02/2023", 1, 2, 2),
            new FirstFruits(13, "Primicias do irmao/irma",  56.60m, DateTime.Now.AddDays(-90), "04/2023", 1, 1, 1),
            new FirstFruits(14, "Primicias do irmao / irma", 565.60m, DateTime.Now.AddDays(-100), "03 /2023", 2, 2, 2),
            new FirstFruits(15, "Primicias do irmao / irma", 156.60m, DateTime.Now.AddDays(-105), "02/2023", 1, 2, 2),
        };

        firstFruitList.ForEach(x => builder.HasData(x));
    }
}