using ChurchCashFlow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureIdentity.Password;

namespace ChurchCashFlow.Data.Mappings;
public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.PassWordHash)
            .IsRequired()
            .HasColumnName("PasswordHash")
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.HasOne(user => user.Church)
            .WithMany(church => church.Users)
            .HasConstraintName("Fk_User_Church")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(user => user.Role)
            .WithMany(roles => roles.Users)
            .HasConstraintName("Fk_User_Role")
            .OnDelete(DeleteBehavior.NoAction);
    }
}