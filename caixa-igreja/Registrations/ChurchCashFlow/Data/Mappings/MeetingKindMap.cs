using DataModelChurchCashFlow.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChurchCashFlow.Data.Mappings;
public class MeetingKindMap : IEntityTypeConfiguration<MeetingKind>
{
    public void Configure(EntityTypeBuilder<MeetingKind> builder)
    {
        builder.ToTable("MeetingKind");
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

    private void InsertDataTemp(EntityTypeBuilder<MeetingKind> builder)
    {
        var meetingsKind = new List<MeetingKind>();
        meetingsKind.Add(new MeetingKind(1, "Culto de Libertação", "Culto dos dias quinta com oração para libertação"));
        meetingsKind.Add(new MeetingKind(2, "Culto de Santa Ceia", "Culto do último domingo do mês com ministração da Santa Ceia do Senhor"));
        meetingsKind.Add(new MeetingKind(3, "Culto de Centésima Ovelha", "Culto do 4º domingo do mês (quando haver 5 domingos). Culto para convidar o amigo "));
        meetingsKind.Add(new MeetingKind(4, "Culto de Prosperidade", "Culto do 2º domingo do mês. Culto das primicias e dizímos"));
        meetingsKind.Add(new MeetingKind(5, "Culto de Missões", "Culto do 3º domingo do mês. Ofertas serão destinas às missões"));
        meetingsKind.Add(new MeetingKind(6, "Culto do Poder", "Culto do 1º domingo do mês. Culto de poder, glória e batismo e renovo do Espirito Santo"));
        meetingsKind.Add(new MeetingKind(7, "Culto de Celebração", "Culto em meio a semana. Culto em outros dias da semana. Redes e Eventos"));

        meetingsKind.ForEach(meeting =>
        {
            builder.HasData(meeting);
        });
    }
}