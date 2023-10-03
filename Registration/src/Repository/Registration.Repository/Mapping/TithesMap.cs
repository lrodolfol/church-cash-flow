using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class TithesMap : IEntityTypeConfiguration<Tithes>
{
    public void Configure(EntityTypeBuilder<Tithes> builder)
    {
        builder.ToTable("Tithes");
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

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("VARCHAR")
            .HasMaxLength(75);

        builder.Property(x => x.TotalAmount)
            .IsRequired()
            .HasColumnName("TotalAmount")
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.Competence)
            .IsRequired()
            .HasColumnName("Competence")
            .HasColumnType("VARCHAR")
            .HasMaxLength(8);

        builder.Property(x => x.OfferingKindId)
            .IsRequired()
            .HasColumnName("OfferingKindId")
            .HasColumnType("INT");

        builder.Property(x => x.ChurchId)
            .IsRequired()
            .HasColumnName("ChurchId")
            .HasColumnType("INT");

        builder.Property(x => x.Photo)
            .HasColumnName("Photo")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.MemberId)
            .IsRequired()
            .HasColumnName("MemberId")
            .HasColumnType("INT");

        builder.HasOne(tithes => tithes.OfferingKind)
            .WithMany(offeringK => offeringK.Tithes)
            .HasConstraintName("Fk_Tithes_Offering_Kind")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(tithes => tithes.Church)
            .WithMany(church => church.Tithes)
            .HasConstraintName("Fk_Tithes_Church")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(tithes => tithes.Member)
            .WithMany(member => member.Tithes)
            .HasConstraintName("Fk_Tithes_Member")
            .OnDelete(DeleteBehavior.NoAction);

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<Tithes> builder)
    {
        var tithes = new List<Tithes>()
        {
            new Tithes(1, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-10), "04/2023", 1, 1, 1),
            new Tithes(2, "dizimo do irmao / irma", 533.45m, DateTime.Now.AddDays(-15), "03/2023", 2, 2, 1),
            new Tithes(3, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-20), "02/2023", 1, 1, 2),
            new Tithes(4, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-25), "02/2023", 1, 1, 2),
            new Tithes(5, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-10), "04/2023", 1, 1, 1),
            new Tithes(6, "dizimo do irmao / irma", 533.45m, DateTime.Now.AddDays(-15), "03/2023", 2, 2, 1),
            new Tithes(7, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-20), "02/2023", 1, 1, 2),
            new Tithes(8, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-25), "02/2023", 1, 1, 2),
            new Tithes(9, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-10), "04/2023", 1, 1, 1),
            new Tithes(10, "dizimo do irmao / irma", 533.45m, DateTime.Now.AddDays(-15), "03/2023", 2, 2, 1),
            new Tithes(11, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-20), "02/2023", 1, 1, 2),
            new Tithes(12, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-25), "02/2023", 1, 1, 2),
            new Tithes(13, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-10), "04/2023", 1, 1, 1),
            new Tithes(14, "dizimo do irmao / irma", 533.45m, DateTime.Now.AddDays(-15), "03/2023", 2, 2, 1),
            new Tithes(15, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-20), "02/2023", 1, 1, 2),
            new Tithes(16, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-25), "02/2023", 1, 1, 2),
            new Tithes(17, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-10), "04/2023", 1, 1, 1),
            new Tithes(18, "dizimo do irmao / irma", 533.45m, DateTime.Now.AddDays(-15), "03/2023", 2, 2, 1),
            new Tithes(19, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-20), "02/2023", 1, 1, 2),
            new Tithes(20, "dizimo do irmao / irma", 33.45m, DateTime.Now.AddDays(-25), "02/2023", 1, 1, 2),
        };

        tithes.ForEach(outF =>
        {
            builder.HasData(outF);
        });
    }
}
