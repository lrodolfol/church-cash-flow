using Microsoft.Extensions.Hosting;
using Registration.DomainBase.Entities.Registrations;
using System.Collections.Generic;

namespace HandlersTest.Builders.Entities;

public class PostTest
{
    public static Post ValidObjectOne()
    {
        var post = new Post(1, "Visitante", "Frequantador avulso dos cultos sem ficha");
        post.Activate(true);
        return post;
    }
    public static Post ValidObjectTwo()
    {
        var post = new Post(2, "Membro", "Frequantador dos cultos com ficha");
        post.Activate(true);
        return post;
    }
    public static Post ValidObjectThree()
    {
        var post =  new Post(3, "Obreiro", "Fazedor da obra");
        post.Activate(true);
        return post;
    }
    public static Post ValidObjectFour()
    {
        var post = new Post(4, "Levita", "Integrante do ministerio de louvor");
        post.Activate(true);
        return post;
    }
    public static Post ValidObjectFive()
    {
        var post = new Post(5, "Diacono", "Cooperador com afazeres da igreja");
        post.Activate(true);
        return post;
    }
    public static Post ValidObjectSix()
    {
        var post =  new Post(6, "Preisbitero", "Ministrante da palavra auxiliar de pastor");
        post.Activate(true);
        return post;
    }
    public static Post ValidObjectSeven()
    {
        var post = new Post(7, "Pastor Axiliar", "Pastor auxiliar da igreja");
        post.Activate(true);
        return post;
    }
    public static Post ValidObjecteEight()
    {
        var post = new Post(8, "Pastor Local", "Pastor titular da igreja");
        post.Activate(true);
        return post;
    }

    public static Post InvalidObjectOne() => new Post(0, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "");
    public static Post InvalidObjectTwo() => new Post(2, "", "");
    public static Post InvalidObjectThree() => new Post(3, "", "");
    public static Post InvalidObjectFour() => new Post(4, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "");
    public static Post InvalidObjectFive() => new Post(5, "", "");
    public static Post InvalidObjectSix() => new Post(6, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "  de ");
    public static Post InvalidObjectSeven() => new Post(7, "", "  da ");
    public static Post InvalidObjecteEight() => new Post(8, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "  da ");



    public static HashSet<int> GetIds() =>
    new HashSet<int>()
    {
            ValidObjectOne().Id,ValidObjectTwo().Id, ValidObjectThree().Id, ValidObjectFour().Id, ValidObjectFive().Id
    };

    public static List<Post> GetValidObjects() =>
    new List<Post>
    {
            ValidObjectOne(),ValidObjectTwo(), ValidObjectThree(), ValidObjectFour(), ValidObjectFive()
    };

    public static IQueryable<Post> GetQueryableValidObjects()
    {
        var listPost = GetValidObjects();
        //IQueryable<Post> queryPost = listPost;

        IQueryable<Post> query =
            listPost.AsQueryable()
            .Cast<Post>()
            .Select(x => x);

        return query;
    }
    
}