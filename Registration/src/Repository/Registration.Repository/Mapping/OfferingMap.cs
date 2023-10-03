using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class OfferingMap : IEntityTypeConfiguration<Offering>
{
    public void Configure(EntityTypeBuilder<Offering> builder)
    {
        builder.ToTable("Offering");
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

        builder.Property(x => x.AdultQuantity)
            .IsRequired()
            .HasColumnName("AdultQuantity")
            .HasColumnType("INT");

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("VARCHAR")
            .HasMaxLength(75);

        builder.Property(x => x.ChildrenQuantity)
            .IsRequired()
            .HasColumnName("ChildrenQuantity")
            .HasColumnType("INT");

        builder.Property(x => x.PreacherMemberName)
            .IsRequired()
            .HasColumnName("PreacherMemberName")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.TotalAmount)
            .IsRequired()
            .HasColumnName("TotalAmount")
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.MeetingKindId)
            .IsRequired()
            .HasColumnName("MeetingKindId")
            .HasColumnType("INT");

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

        builder.HasOne(offering => offering.MeetingKind)
            .WithMany(meeting => meeting.Offerings)
            .HasConstraintName("Fk_Offering_MeetingKind");

        builder.HasOne(offering => offering.OfferingKind)
            .WithMany(offeringK => offeringK.Offerings)
            .HasConstraintName("Fk_Offering_Offering_Kind")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(offering => offering.Church)
            .WithMany(church => church.Offerings)
            .HasConstraintName("Fk_Offering_Church")
            .OnDelete(DeleteBehavior.NoAction);

        InsertDataTemp(builder);    
    }

    private void InsertDataTemp(EntityTypeBuilder<Offering> builder)
    {
        var offeringList = new List<Offering>
        {
            new Offering(1, "oferta do irmao / irma", DateTime.Now.AddDays(-10), "2023/05", 25, 4, 55.90m, "Pr Antônio Cristino Alves", 1, 1, 1),
            new Offering(2, "oferta do irmao / irma", DateTime.Now.AddDays(-15), "2023/04", 25, 4, 326.05m, "Obª Kelly Cristina Martins", 2, 2, 2),
            new Offering(3, "oferta do irmao / irma", DateTime.Now.AddDays(-20), "2023/03", 25, 4, 12.80m, "Dcª Iolanda da Silva Souza", 3, 3, 1),
            new Offering(4, "oferta do irmao / irma", DateTime.Now.AddDays(-25), "2023/02", 25, 4, 55.90m, "Pr Antônio Cristino Alves", 1, 1, 1),
            new Offering(5, "oferta do irmao / irma", DateTime.Now.AddDays(-30), "2023/01", 25, 4, 326.05m, "Obª Kelly Cristina Martins", 2, 2, 2),
            new Offering(6, "oferta do irmao / irma", DateTime.Now.AddDays(-35), "2023/05", 25, 4, 12.80m, "Dcª Iolanda da Silva Souza", 3, 3, 1),
            new Offering(7, "oferta do irmao / irma", DateTime.Now.AddDays(-40), "2023/04", 25, 4, 55.90m, "Pr Antônio Cristino Alves", 1, 1, 1),
            new Offering(8, "oferta do irmao / irma", DateTime.Now.AddDays(-45), "2023/03", 25, 4, 326.05m, "Obª Kelly Cristina Martins", 2, 2, 2),
            new Offering(9, "oferta do irmao / irma", DateTime.Now.AddDays(-50), "2023/02", 25, 4, 12.80m, "Dcª Iolanda da Silva Souza", 3, 3, 1),
            new Offering(10, "oferta do irmao / irma", DateTime.Now.AddDays(-55), "2023/01", 25, 4, 55.90m, "Pr Antônio Cristino Alves", 1, 1, 1),
            new Offering(11, "oferta do irmao / irma", DateTime.Now.AddDays(-60), "2023/05", 25, 4, 326.05m, "Obª Kelly Cristina Martins", 2, 2, 2),
            new Offering(12, "oferta do irmao / irma", DateTime.Now.AddDays(-65), "2023/04", 25, 4, 12.80m, "Dcª Iolanda da Silva Souza", 3, 3, 1),
            new Offering(13, "oferta do irmao / irma", DateTime.Now.AddDays(-70), "2023/03", 25, 4, 55.90m, "Pr Antônio Cristino Alves", 1, 1, 1),
            new Offering(14, "oferta do irmao / irma", DateTime.Now.AddDays(-75), "2023/02", 25, 4, 326.05m, "Obª Kelly Cristina Martins", 2, 2, 2),
            new Offering(15, "oferta do irmao / irma", DateTime.Now.AddDays(-80), "2023/01", 25, 4, 12.80m, "Dcª Iolanda da Silva Souza", 3, 3, 1),
            new Offering(16, "oferta do irmao / irma", DateTime.Now.AddDays(-85), "2023/05", 25, 4, 55.90m, "Pr Antônio Cristino Alves", 1, 1, 1),
            new Offering(17, "oferta do irmao / irma", DateTime.Now.AddDays(-90), "2023/04", 25, 4, 326.05m, "Obª Kelly Cristina Martins", 2, 2, 2),
            new Offering(18, "oferta do irmao / irma", DateTime.Now.AddDays(-95), "2023/03", 25, 4, 12.80m, "Dcª Iolanda da Silva Souza", 3, 3, 1),
            new Offering(19, "oferta do irmao / irma", DateTime.Now.AddDays(-100), "2023/02", 25, 4, 55.90m, "Pr Antônio Cristino Alves", 1, 1, 1),
            new Offering(20, "oferta do irmao / irma", DateTime.Now.AddDays(-105), "2023/01", 25, 4, 326.05m, "Obª Kelly Cristina Martins", 2, 2, 2),
            new Offering(21, "oferta do irmao / irma", DateTime.Now.AddDays(-115), "2023/05", 25, 4, 12.80m, "Dcª Iolanda da Silva Souza", 3, 3, 1)
        };

        offeringList.ForEach(x =>
        {
            builder.HasData(x);
        });
    }
}