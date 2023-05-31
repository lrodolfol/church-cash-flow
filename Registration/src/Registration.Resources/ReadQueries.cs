namespace Registration.Resources;

public class ReadQueries
{
    public static string MonthlyClosingOutFlow(string churchId, string month, string year)
    {
        var query = Scripts.MonthlyClosingOutFlow;
        return string.Format(query, churchId, month, year);
    }
    public static string MonthlyClosingTithes(string churchId, string month, string year)
    {
        var query = Scripts.MonthlyClosingTithes;
        return string.Format(query, churchId, month, year);
    }
    public static string MonthlyClosingOffering(string churchId, string month, string year)
    {
        var query = Scripts.MonthlyClosingOffering;
        return string.Format(query, churchId, month, year);
    }
    public static string MonthlyClosingFirstFruits(string churchId, string month, string year)
    {
        var query = Scripts.MonthlyClosingFirstFruits;
        return string.Format(query, churchId, month, year);
    }
}