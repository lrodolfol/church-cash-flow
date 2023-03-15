using DataModelChurchCashFlow.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChurchCashFlow.Data.Mappings;
public class MemberMap : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable("Member");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.DateBirth)
            .IsRequired()
            .HasColumnName("DateBirth")
            .HasColumnType("DATE");

        builder.HasOne(membro => membro.Post)
            .WithOne()
            .HasConstraintName("Fk_Member_Post")
            .OnDelete(DeleteBehavior.NoAction);

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<Member> builder)
    {
        var dd = new DateTime(1995, 5, 6);
        var members = new List<Member>();
        members.Add(new Member(1, "Isaque de souza", DateTime.Parse("2021-05-06"), 1));
        members.Add(new Member(2, "Fernanda Miranda", DateTime.Parse("2021-05-06"), 2));
        members.Add(new Member(3, "Gabriela Soares", DateTime.Parse("2021-05-06"), 3));
        members.Add(new Member(4, "João Vitor Nascimento", DateTime.Parse("2021-05-06"), 4));
        members.Add(new Member(5, "Mauricio Emanuel", DateTime.Parse("2021-05-06"), 5));
        members.Add(new Member(6, "Joana Darc Crispim", DateTime.Parse("2021-05-06"), 6));
        members.Add(new Member(7, "Rogerio Gegrório Martins", DateTime.Parse("2021-05-06"), 7));
        members.Add(new Member(8, "Valéria De Carvalho", DateTime.Parse("2021-05-06"), 8));
        members.Add(new Member(9, "Taisa Fonseca da Silva", DateTime.Parse("2021-05-06"), 9));
        members.Add(new Member(10, "Auxiliadora de Souza Morais", DateTime.Parse("2021-05-06"), 10));
        members.Add(new Member(11, "Victor Figueredo Junior", DateTime.Parse("2021-05-06"), 11));

        foreach (var member in members)
        {
            builder.HasData(member);
        }
    }
}