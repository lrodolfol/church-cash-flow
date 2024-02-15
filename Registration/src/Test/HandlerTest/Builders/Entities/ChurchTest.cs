using Registration.DomainBase.Entities.Registrations;
using System.ComponentModel.DataAnnotations;

namespace HandlersTest.Builders.Entities;

public class ChurchTest : Entitie
{
    public static Church ValidObjectOne()
    {
        var address = AddressTest.ValidObjectOne();
        var church = new Church(1, "CEO Carmo", new DateTime(2023, 11, 01), new DateTime(2023, 10, 01), address.Id, "CEO-CRM");
        church.AddAddress(address);

        return church;
    }
    public static Church ValidObjectTwo()
    {
        var address = AddressTest.ValidObjectTwo();
        var church = new Church(2, "CEO Soledade", new DateTime(2023, 11, 01), new DateTime(2023, 10, 01), address.Id, "CEO-SLD");
        church.AddAddress(address);

        return church;

    }

    public static Church ValidObjectThree()
    {
        var address = AddressTest.ValidObjectThree();
        var church = new Church(2, "CEO Lambari", new DateTime(2023, 11, 01), new DateTime(2023, 10, 01), address.Id, "CEO-LBR");
        church.AddAddress(address);

        return church;

    }


}