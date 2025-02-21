using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class UserRoleMap : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("UserRole");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.UserId)
            .IsRequired()
            .HasColumnName("UserId")
            .HasColumnType("INT");

        builder.Property(x => x.RoleId)
            .IsRequired()
            .HasColumnName("RoleId")
            .HasColumnType("INT");

        builder.HasOne(userRole => userRole.User)
            .WithMany(user => user.UserRoles)
            .HasConstraintName("Fk_Users_UserRole")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(userRole => userRole.Role)
            .WithMany(role => role.UserRoles)
            .HasConstraintName("Fk_Role_UserRole")
            .OnDelete(DeleteBehavior.NoAction);

       InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<UserRole> builder)
    {
        var uRoles = new List<UserRole>
        {
            //ALL ROLES
            new UserRole(1, 1, 1),
            new UserRole(2, 1, 2),
            new UserRole(3, 1, 3),
            new UserRole(4, 1, 4),

            //JUST L-SCT
            new UserRole(5, 2, 1),

            //JUST M-SCT
            new UserRole(6, 3, 3),

            //JUST M-TRS
            new UserRole(7, 4, 4)
        };

        foreach (var role in uRoles)
        {
            builder.HasData(role);
        }
    }
}