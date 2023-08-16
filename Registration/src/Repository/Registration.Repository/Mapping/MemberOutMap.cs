using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;

public class MemberOutMap : IEntityTypeConfiguration<MemberOut>
{
    public void Configure(EntityTypeBuilder<MemberOut> builder)
    {
        builder.ToTable("MemberOut");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.MemberId)
            .IsRequired()
            .HasColumnName("MemberId")
            .HasColumnType("INT");

        builder.Property(x => x.Reason)
            .IsRequired()
            .HasColumnName("Reason")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.Day)
            .IsRequired()
            .HasColumnName("Day")
            .HasColumnType("DATE")
            .HasMaxLength(50);
    }
}