using Registration.DomainBase.Entities.Registrations;

namespace HandlersTest.Builders.Entities;

public class AddressTest
{
    public static Address ValidObjectOne() =>
        new Address(1, "Brasil", "Minas Gerais", "Carmos de minas", "37490-000", "Centro", "Rua projetada", "", 1042);

    public static Address ValidObjectTwo() =>
        new Address(2, "Brasil", "Minas Gerais", "Soledade", "37120-000", "Rodoviaria", "Rua XV de novembro", "bloco 1", 75);
    public static Address ValidObjectThree() =>
    new Address(2, "Brasil", "Minas Gerais", "Lambari", "4786-100", "Centro", "Praça Vivald Leite", "Predio 1", 106);

    public static Address InvalidObjectOne() =>
        new Address(0, "A", "B", "Carmos de minas", "3", "Centro", "Rua projetada", "", 0);

    public static Address InvalidObjectTwo() =>
    new Address(0, "Z", "Y", "Carmos de minas", "3", "Centro", "Rua projetada", "", 0);
}