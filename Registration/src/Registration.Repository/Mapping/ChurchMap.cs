using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class ChurchMap : IEntityTypeConfiguration<Church>
{
    public void Configure(EntityTypeBuilder<Church> builder)
    {
        builder.ToTable("Church");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true); 

        builder.HasOne(church => church.Address)
            .WithOne()
            .HasConstraintName("Fk_Church_Address")
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(x => x.FirstTreasurerId)
            .IsRequired()
            .HasColumnName("FirstTreasurerId")
            .HasColumnType("INT");

        builder.Property(x => x.SecondTreasurerId)
            .IsRequired()
            .HasColumnName("SecondTreasurerId")
            .HasColumnType("INT");

        builder.Property(x => x.FirstSecretaryId)
            .IsRequired()
            .HasColumnName("FirstSecretaryId")
            .HasColumnType("INT");

        builder.Property(x => x.SecondSecretaryId)
            .IsRequired()
            .HasColumnName("SecondSecretaryId")
            .HasColumnType("INT");

        builder.Property(x => x.FirstPastorId)
            .IsRequired()
            .HasColumnName("FistPastorId")
            .HasColumnType("INT");

        builder.Property(x => x.SecondPastorId)
            .IsRequired()
            .HasColumnName("SecondPastorId")
            .HasColumnType("INT");

        //------

        builder.HasOne(church => church.FirstTreasurer)
            .WithMany()
            .HasForeignKey(church => church.FirstTreasurerId)
            .HasConstraintName("Fk_Church_FirstTreasurer")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(church => church.SecondTreasurer)
            .WithMany()
            .HasForeignKey(church => church.SecondTreasurerId)
            .HasConstraintName("Fk_Church_SecondTreasurer")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(church => church.FirstSecretary)
            .WithMany()
            .HasForeignKey(church => church.FirstSecretaryId)
            .HasConstraintName("Fk_Church_FirstSecretary")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(church => church.SecondSecretary)
            .WithMany()
            .HasForeignKey(church => church.SecondSecretaryId)
            .HasConstraintName("Fk_Church_SecondSecretary")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(church => church.FirstPastor)
            .WithMany()
            .HasForeignKey(church => church.FirstPastorId)
            .HasConstraintName("Fk_Church_FistPastor")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(church => church.SecondPastor)
            .WithMany()
            .HasForeignKey(church => church.SecondPastorId)
            .HasConstraintName("Fk_Church_SecondPastor")
            .OnDelete(DeleteBehavior.NoAction);
        //--------


        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<Church> builder)
    {
        builder.HasData(new Church(1, "CEO São Lourenço", 1, "SLC",1,2,1,2,1,2));
        builder.HasData(new Church(2, "CEP Cristina", 2, "CRT", 1, 2, 1, 2, 1, 2));
        builder.HasData(new Church(3, "CEP Lambari", 3, "LBR", 1, 2, 1, 2, 1, 2));
    }
}
