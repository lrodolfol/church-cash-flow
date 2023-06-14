using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class RoleMap : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Role");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<Role> builder)
    {
        var role = new Role(1, "L-SCT");
        builder.HasData(role);

        role = new Role(2, "L-TRS");
        builder.HasData(role);

        role = new Role(3, "M-SCT");
        builder.HasData(role);

        role = new Role(4, "M-TRS");
        builder.HasData(role);
    }
}