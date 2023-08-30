using Registration.DomainBase.Entities.Registrations;
using System.ComponentModel.DataAnnotations;

namespace HandlersTest.Builders.Entities;

public class ChurchTest : Entitie
{
    public static Church ValidObjectOne()
    {
        var address = AddressTest.ValidObjectOne();
        var church = new Church(1, "CEO Carmo", 1, "CEO-CRM");
        church.AddAddress(address);

        return church;
    }
    public static Church ValidObjectTwo()
    {
        var address = AddressTest.ValidObjectTwo();
        var church = new Church(2, "CEO Soledade", 1, "CEO-SLD");
        church.AddAddress(address);

        return church;

    }
         
    
}