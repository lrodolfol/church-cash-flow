using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;

public class MemberInMap : IEntityTypeConfiguration<MemberIn>
{
    public void Configure(EntityTypeBuilder<MemberIn> builder)
    {
        builder.ToTable("MemberIn");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.MemberId)
            .IsRequired()
            .HasColumnName("MemberId")
            .HasColumnType("INT");

        builder.Property(x => x.ChurchName)
            .IsRequired()
            .HasColumnName("ChurchName")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.LastPost)
            .IsRequired()
            .HasColumnName("LastPost")
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.LetterReceiver)
            .IsRequired()
            .HasColumnName("LetterReceiver")
            .HasColumnType("VARCHAR")
            .HasMaxLength(15);
    }
}