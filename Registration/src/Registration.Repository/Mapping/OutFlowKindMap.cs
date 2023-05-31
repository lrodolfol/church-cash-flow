using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class OutFlowKindMap : IEntityTypeConfiguration<OutFlowKind>
{
    public void Configure(EntityTypeBuilder<OutFlowKind> builder)
    {
        builder.ToTable("OutFlowKind");
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

    private void InsertDataTemp(EntityTypeBuilder<OutFlowKind> builder)
    {
        var outFlowKind = new List<OutFlowKind>();
        outFlowKind.Add(new OutFlowKind(1, "Energia", "Conta de Luz"));
        outFlowKind.Add(new OutFlowKind(2, "Água", "Conta de água"));
        outFlowKind.Add(new OutFlowKind(3, "Zeladoria", "Produto de limpeza"));
        outFlowKind.Add(new OutFlowKind(4, "Auxilio Ministrante", "Oferta de gratidão para ministrante convidado"));

        outFlowKind.ForEach(meeting =>
        {
            builder.HasData(meeting);
        });
    }
}