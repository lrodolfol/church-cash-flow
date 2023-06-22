using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registration.DomainBase.Entities.Registrations;

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

        //MEMBRO NORMAL
        posts.Add(new Post(1, "Visitante avulso", "Pessoa visitante eventual"));
        posts.Add(new Post(2, "Visitante frequente", "Pessoa visitante frenquente"));
        posts.Add(new Post(3, "Membro", "Membro batisado com ficha"));
        posts.Add(new Post(4, "Visitante frequente", "Membro batisado lider espiritual e administrativo da Igreja"));

        //OBREIROS
        posts.Add(new Post(5, "Levita", "Membro batisado pertencente ao grupo de louvor"));
        posts.Add(new Post(6, "Obreiro", "Membro batisado ajudante nos cultos"));
        posts.Add(new Post(7, "Diacono", "Membro batisado cooperador da obra"));

        //COBERTORES ESPIRITUAIS
        posts.Add(new Post(8, "Preisbitero", "Membro batisado auxiliador do pastor"));
        posts.Add(new Post(9, "Pastor responsável", "Membro batisado lider espiritual e lider administrativo da Igreja"));
        posts.Add(new Post(10, "Pastor Auxiliar", "Membro batisado lider espiritual da Igreja"));
        posts.Add(new Post(11, "Bispo", "Membro batisado lider da cobertura espiritual"));

        //EX-MEMBROS
        posts.Add(new Post(12, "Transferido", "Membro batisado porém transferido sob benção para outra igreja"));
        posts.Add(new Post(13, "Desligado", "Membro batisado porém afastado da igreja"));

        //TRABALHOS
        posts.Add(new Post(14, "Primeiro tesoureiro", "Membro batisado responsável pelo gerenciamento contábil da igreja"));
        posts.Add(new Post(15, "Segundo tesoureito", "Membro batisado sub-responsável pelo gerenciamento contábil da igreja"));
        posts.Add(new Post(16, "Primeiro secretario", "Membro batisado responsável pela organização documental e numeros estatisticos da igreja"));
        posts.Add(new Post(17, "Segundo tesoureito", "Membro batisado sub-responsável pela organização documental e numeros estatisticos da igreja"));
        posts.Add(new Post(18, "Zeladoria", "Membro cooperador na organização, limpeza e zelo dos bens físicos da igreja"));

        //LIDERES DE REDE
        posts.Add(new Post(19, "Lider de celula", "Membro batisado responsável por uma celula"));
        posts.Add(new Post(20, "Vice-lider de celula", "Membro batisado sub-responsável por uma celula"));

        posts.Add(new Post(21, "Lider de louvor", "Membro batisado responsável pelo louvor da igreja"));
        posts.Add(new Post(22, "Vice-lider de louvor", "Membro batisado sub-responsável pelo louvor da igreja"));

        foreach (var post in posts)
        {
            builder.HasData(post);
        }
    }
}