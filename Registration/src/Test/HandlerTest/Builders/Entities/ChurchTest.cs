using Registration.DomainBase.Entities.Registrations;
using System.ComponentModel.DataAnnotations;

namespace HandlersTest.Builders.Entities;

public class ChurchTest : Entitie
{
    public static Church ValidObjectOne()
    {
        var address = AddressTest.ValidObjectOne();
        var church = new Church(1, "CEO Carmo", address.Id, "CEO-CRM");
        church.AddAddress(address);

        return church;
    }
    public static Church ValidObjectTwo()
    {
        var address = AddressTest.ValidObjectTwo();
        var church = new Church(2, "CEO Soledade", address.Id, "CEO-SLD");
        church.AddAddress(address);

        return church;

    }

    public static Church ValidObjectThree()
    {
        var address = AddressTest.ValidObjectThree();
        var church = new Church(2, "CEO Lambari", address.Id, "CEO-LBR");
        church.AddAddress(address);

        return church;

    }


}