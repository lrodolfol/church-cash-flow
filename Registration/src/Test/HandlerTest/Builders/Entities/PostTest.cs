using Registration.DomainBase.Entities.Registrations;

namespace HandlersTest.Builders.Entities;

public class PostTest
{
    public static Post ValidObjectOne() => new Post(1, "Visitante", "Frequantador avulso dos cultos sem ficha");
    public static Post ValidObjectTwo() => new Post(2, "Membro", "Frequantador dos cultos com ficha");
    public static Post ValidObjectThree() => new Post(3, "Obreiro", "Fazedor da obra");
    public static Post ValidObjectFour() => new Post(4, "Levita", "Integrante do ministerio de louvor");
    public static Post ValidObjectFive() => new Post(5, "Diacono", "Cooperador com afazeres da igreja");
    public static Post ValidObjectSix() => new Post(6, "Preisbitero", "Ministrante da palavra auxiliar de pastor");
    public static Post ValidObjectSeven() => new Post(7, "Pastor Axiliar", "Pastor auxiliar da igreja");
    public static Post ValidObjecteEight() => new Post(8, "Pastor Local", "Pastor titular da igreja");

    public static Post InvalidObjectOne() => new Post(0, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "");
    public static Post InvalidObjectTwo() => new Post(2, "", "");
    public static Post InvalidObjectThree() => new Post(3, "", "");
    public static Post InvalidObjectFour() => new Post(4, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "");
    public static Post InvalidObjectFive() => new Post(5, "", "");
    public static Post InvalidObjectSix() => new Post(6, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "  de ");
    public static Post InvalidObjectSeven() => new Post(7, "", "  da ");
    public static Post InvalidObjecteEight() => new Post(8, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "  da ");
}