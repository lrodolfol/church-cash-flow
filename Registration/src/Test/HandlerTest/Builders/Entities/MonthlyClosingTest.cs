using Registration.DomainBase.Entities.Operations;

namespace HandlersTest.Builders.Entities;

public class MonthlyClosingTest
{
    public static MonthlyClosing ValidObjectOneInput() =>
        new MonthlyClosing()
        {
            Competence = DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yyyy"),
            PreviousBalance = 0,
            Title = "Entrada de ofertas",
            Description = "Ofertas de domingo de santa ceia",
            AmountInputOperation = 581.5m,
            AmountOutPutOperation = 0,
        };
    public static MonthlyClosing ValidObjectTwoInput() =>
    new MonthlyClosing()
    {
        Competence = DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yyyy"),
        PreviousBalance = 8966m,
        Title = "Entrada de Dizimos",
        Description = "Ofertas de quinta",
        AmountInputOperation = 581.5m,
        AmountOutPutOperation = 0,
    };

    public static MonthlyClosing ValidObjectOneOutput() =>
    new MonthlyClosing()
    {
        Competence = DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yyyy"),
        PreviousBalance = 352.55m,
        Title = "CEMIG",
        Description = "Debito de conta de luz",
        AmountInputOperation = 0,
        AmountOutPutOperation = 100
    };
    public static MonthlyClosing ValidObjectTwoOutput() =>
    new MonthlyClosing()
    {
        Competence = DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yyyy"),
        PreviousBalance = 352.55m,
        Title = "Parcela terreno",
        Description = "Pagamento da parcela do terrno",
        AmountInputOperation = 0,
        AmountOutPutOperation = 120,
    };


    public static List<MonthlyClosing> GetValidObjectes()
    {
        return new List<MonthlyClosing>()
        {
            ValidObjectOneInput(),ValidObjectTwoInput(), ValidObjectOneOutput(), ValidObjectTwoOutput()
        };
    }
}