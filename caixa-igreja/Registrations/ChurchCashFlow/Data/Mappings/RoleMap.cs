using ChurchCashFlow.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChurchCashFlow.Data.Mappings
{
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
            var role = new Role(1, "LOCAL");
            builder.HasData(role);

            role = new Role(2, "MINISTERIO");
            builder.HasData(role);
        }
    }
}
