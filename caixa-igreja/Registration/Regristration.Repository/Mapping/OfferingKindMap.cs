using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Mapping;
public class OfferingKindMap : IEntityTypeConfiguration<OfferingKind>
{
    public void Configure(EntityTypeBuilder<OfferingKind> builder)
    {
        builder.ToTable("OfferingKind");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<OfferingKind> builder)
    {
        var offeringsKind = new List<OfferingKind>();
        offeringsKind.Add(new OfferingKind(1, "PIX", "Oferta de amor com pix"));
        offeringsKind.Add(new OfferingKind(2, "Cédulas", "Oferta de amor com Cédulas"));
        offeringsKind.Add(new OfferingKind(3, "Crédito/Débito", "Oferta de amor com cartão crédito/débito"));
        offeringsKind.Add(new OfferingKind(4, "Transferência", "Oferta de amor com TED/DOC"));

        offeringsKind.ForEach(meeting =>
        {
            builder.HasData(meeting);
        });
    }
}