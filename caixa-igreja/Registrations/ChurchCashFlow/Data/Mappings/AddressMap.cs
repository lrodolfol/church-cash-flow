using ChurchCashFlow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChurchCashFlow.Data.Mappings;
public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Adress");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Country)
            .IsRequired()
            .HasColumnName("Country")
            .HasColumnType("VARCHAR")
            .HasMaxLength(60);

        builder.Property(x => x.State)
            .IsRequired()
            .HasColumnName("State")
            .HasColumnType("VARCHAR")
            .HasMaxLength(60);

        builder.Property(x => x.City)
            .IsRequired()
            .HasColumnName("City")
            .HasColumnType("VARCHAR")
            .HasMaxLength(60);

        builder.Property(x => x.ZipCode)
            .IsRequired()
            .HasColumnName("ZipCode")
            .HasColumnType("VARCHAR")
            .HasMaxLength(15);

        builder.Property(x => x.District)
            .HasColumnName("District")
            .HasColumnType("VARCHAR")
            .HasMaxLength(30);

        builder.Property(x => x.Street)
            .IsRequired()
            .HasColumnName("Street")
            .HasColumnType("VARCHAR")
            .HasMaxLength(60);

        builder.Property(x => x.Additional)
            .IsRequired()
            .HasColumnName("Additional")
            .HasColumnType("VARCHAR")
            .HasMaxLength(60);

        builder.Property(x => x.Number)
            .HasMaxLength(6);


    }
}
