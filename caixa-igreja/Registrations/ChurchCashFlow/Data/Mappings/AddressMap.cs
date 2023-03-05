using ChurchCashFlow.Data.Entities;
using DataModelChurchCashFlow.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChurchCashFlow.Data.Mappings;
public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Address");
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

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<Address> builder)
    {
        builder.HasData
            (new Address
            {
                Id = 1,
                Country = "Brasil",
                State = "Minas Gerais",
                City = "São Lourenço",
                ZipCode = "37470-000",
                District = "Centro",
                Street = "Rua Dr Ribeiro da Luz",
                Number = 780,
                Additional = ""
            });
        builder.HasData
            (new Address
            {
                Id = 2,
                Country = "Brasil",
                State = "Rio de Janeiro",
                City = "Itaguai",
                ZipCode = "13710-000",
                District = "Mesquita",
                Street = "Avenida André Chaves",
                Number = 258,
                Additional = "Prédio 1"
            });

    }
}
