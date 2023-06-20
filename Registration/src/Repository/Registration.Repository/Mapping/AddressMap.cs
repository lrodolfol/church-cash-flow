using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
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
        var addresses = new List<Address>();
        addresses.Add(new Address(1,"Brasil","Minas Gerais","São Lourenço","37470-000","Centro","Rua Dr Ribeiro da Luz","", 780));
        addresses.Add(new Address(2, "Brasil", "Rio de Janeiro", "Itaguai", "13710-000", "Mesquita", "Avenida André Chaves", "Prédio 1", 258));
        addresses.Add(new Address(3, "Brasil", "Rio de Janeiro", "Rio de Janeiro", "13770-000", "Nilopolis", "Avenida André Chaves", "Prédio 2", 1039));

        addresses.Add(new Address(4, "Brasil", "Minas Gerais", "Lambari", "37471-000", "Centro", "Rua Dr Ribeiro da Luz", "s/n", 780));
        addresses.Add(new Address(5, "Brasil", "Rio de Janeiro", "Caxambu", "14710-000", "Mesquita", "Avenida André Chaves", "", 2518));
        addresses.Add(new Address(6, "Brasil", "Rio de Janeiro", "Baipendi", "11710-000", "Pedras", "Avenida André Chaves", "via duto", 13));

        builder.HasData(addresses.Select(x => x));
    }
}
