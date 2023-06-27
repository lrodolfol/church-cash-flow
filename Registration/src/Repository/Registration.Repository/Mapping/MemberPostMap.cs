using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Repository.Mapping;
public class MemberPostMap : IEntityTypeConfiguration<MemberPost>
{
    public void Configure(EntityTypeBuilder<MemberPost> builder)
    {
        builder.ToTable("MemberPost");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active")
            .HasColumnType("BIT")
            .HasDefaultValue(true);

        builder.Property(x => x.MemberId)
            .IsRequired()
            .HasColumnName("MemberId")
            .HasColumnType("INT");

        builder.Property(x => x.PostId)
            .IsRequired()
            .HasColumnName("PostId")
            .HasColumnType("INT");

        builder.HasOne(memberPost => memberPost.Members)
            .WithMany(members => members.MemberPost)
            .HasConstraintName("Fk_Members_MemberPost")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(memberPost => memberPost.Posts)
            .WithMany(role => role.MemberPost)
            .HasConstraintName("Fk_Posts_MemberPost")
            .OnDelete(DeleteBehavior.NoAction);

       InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<MemberPost> builder)
    {
        var mPosts = new List<MemberPost>
        {
            new MemberPost(1, 1, 5),   
            new MemberPost(2, 1, 2),   
            new MemberPost(3, 1, 10),   
            new MemberPost(4, 2, 6),   
            new MemberPost(5, 2, 9),   
            new MemberPost(6, 2, 4)
        };

        foreach (var post in mPosts)
        {
            builder.HasData(post);
        }
    }
}