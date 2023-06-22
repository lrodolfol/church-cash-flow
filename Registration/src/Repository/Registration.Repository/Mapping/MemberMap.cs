using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class MemberMap : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable("Member");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.Photo)
            .HasColumnName("Photo")
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(x => x.DateBirth)
            .IsRequired()
            .HasColumnName("DateBirth")
            .HasColumnType("DATE");        
        
        builder.Property(x => x.DateBaptism)
            .IsRequired()
            .HasColumnName("DateBaptism")
            .HasColumnType("DATE");

        builder.Property(x => x.Code)
            .IsRequired()
            .HasColumnName("Code")
            .HasColumnType("VARCHAR")
            .HasMaxLength(11);

        builder.HasOne(member => member.Church)
            .WithMany(church => church.Members)
            .HasConstraintName("Fk_Member_Church")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(x => x.Code, "IX_Member_Code")
            .IsUnique();

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<Member> builder)
    {
        var membersList = new List<Member>()
        {
            new Member(1, "Rodolfo de Jesus Silva", DateTime.Now.AddYears(-20), DateTime.Now.AddDays(-10), 2, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(2, "Kelly Cristina Martins", DateTime.Now.AddYears(-24), DateTime.Now.AddDays(-15), 3, 2, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(3, "Manuela Martins de Jesus", DateTime.Now.AddYears(-18), DateTime.Now.AddDays(-20), 4, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(4, "Rodolfo de Jesus Silva", DateTime.Now.AddYears(-20), DateTime.Now.AddDays(-25), 2, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(5, "Kelly Cristina Martins", DateTime.Now.AddYears(-24), DateTime.Now.AddDays(-30), 3, 2, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(6, "Manuela Martins de Jesus", DateTime.Now.AddYears(-18), DateTime.Now.AddDays(-35), 4, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(7, "Rodolfo de Jesus Silva", DateTime.Now.AddYears(-20), DateTime.Now.AddDays(-40), 2, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(8, "Kelly Cristina Martins", DateTime.Now.AddYears(-24), DateTime.Now.AddDays(-45), 3, 2, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(9, "Manuela Martins de Jesus", DateTime.Now.AddYears(-18), DateTime.Now.AddDays(-50), 4, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(10, "Rodolfo de Jesus Silva", DateTime.Now.AddYears(-20), DateTime.Now.AddDays(-55), 2, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(11, "Kelly Cristina Martins", DateTime.Now.AddYears(-24), DateTime.Now.AddDays(-60), 3, 2, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(12, "Manuela Martins de Jesus", DateTime.Now.AddYears(-18), DateTime.Now.AddDays(-65), 4, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(13, "Rodolfo de Jesus Silva", DateTime.Now.AddYears(-20), DateTime.Now.AddDays(-70), 2, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(14, "Kelly Cristina Martins", DateTime.Now.AddYears(-24), DateTime.Now.AddDays(-75), 3, 2, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(15, "Manuela Martins de Jesus", DateTime.Now.AddYears(-18), DateTime.Now.AddDays(-80), 4, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(16, "Rodolfo de Jesus Silva", DateTime.Now.AddYears(-20), DateTime.Now.AddDays(-85), 2, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(17, "Kelly Cristina Martins", DateTime.Now.AddYears(-24), DateTime.Now.AddDays(-90), 3, 2, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
            new Member(18, "Manuela Martins de Jesus", DateTime.Now.AddYears(-18), DateTime.Now.AddDays(-95), 4, 1, $"{"SLC"}-{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}"),
        };

        membersList.ForEach(x =>
        {
            builder.HasData(x);
        });
        
    }
}