using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities;

namespace Regristration.Repository.Mapping;
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

        builder.Property(x => x.Code)
            .IsRequired()
            .HasColumnName("Code")
            .HasColumnType("VARCHAR")
            .HasMaxLength(11);

        builder.HasOne(member => member.Post)
            .WithMany(post => post.Members)
            .HasConstraintName("Fk_Member_Post")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(member => member.Church)
            .WithMany(church => church.Members)
            .HasConstraintName("Fk_Member_Church")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(x => x.Code, "IX_Member_Code")
            .IsUnique();
    }
}