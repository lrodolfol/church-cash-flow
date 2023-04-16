using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Mapping;
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
            new Offering(1, DateTime.Now, 25, 4, 55.90m, "Pr Antônio Cristino Alves", 1, 1, 1),
            new Offering(2, DateTime.Now, 25, 4, 326.05m, "Obª Kelly Cristina Martins", 2, 2, 2),
            new Offering(3, DateTime.Now, 25, 4, 12.80m, "Dcª Iolanda da Silva Souza", 3, 3, 1)
        };

        offeringList.ForEach(x =>
        {
            builder.HasData(x);
        });
    }
}