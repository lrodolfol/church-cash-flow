using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities;

namespace Registration.Repository.Mapping;
public class PostMap : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Post");
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
            .HasMaxLength(30);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        InsertDataTemp(builder);
    }

    private void InsertDataTemp(EntityTypeBuilder<Post> builder)
    {
        var posts = new List<Post>();
        posts.Add(new Post(1, "Visitante avulso", "Pessoa visitante eventual"));
        posts.Add(new Post(2, "Visitante frequente", "Pessoa visitante frenquente"));
        posts.Add(new Post(3, "Membro", "Membro batisado com ficha"));
        posts.Add(new Post(4, "Levita", "Membro batisado pertencente ao grupo de louvor"));
        posts.Add(new Post(5, "Obreiro", "Membro batisado ajudante nos cultos"));
        posts.Add(new Post(6, "Diacono", "Membro batisado cooperador da obra"));
        posts.Add(new Post(7, "Preisbitero", "Membro batisado auxiliador do pastor"));
        posts.Add(new Post(8, "Pastor Auxiliar", "Membro batisado lider espiritual da Igreja"));
        posts.Add(new Post(9, "Visitante frequente", "Membro batisado lider espiritual e administrativo da Igreja"));
        posts.Add(new Post(10, "Bispo", "Membro batisado lider da cobertura espiritual"));
        posts.Add(new Post(11, "Transferido", "Membro batisado porém transferido sob benção para outra igreja"));
        posts.Add(new Post(12, "Desligado", "Membro batisado porém afastado da igreja"));

        foreach (var post in posts)
        {
            builder.HasData(post);
        }
    }
}