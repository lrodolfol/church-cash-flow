﻿namespace Registration.Resources;

public class ReadQueries
{
    public static string MonthlyValueMonthMinus1(string churchId, string month, string year)
    {
        var query = Scripts.MonthlyValueMonthMinus1;
        if(month == "01" || month == "1")
        {
            month = "12";
            year = (int.Parse(year) - 1).ToString();
        }
        else
        {
            month = (int.Parse(month) - 1).ToString("0#");
        }

        return string.Format(query, churchId, year, month);
    }
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
    public static string MonthlyTithers(string churchId, string month, string year)
    {
        var query = Scripts.MonthlyTithers;
        return string.Format(query, churchId, month, year);
    }
    public static string MonthlyOffering(string churchId, string month, string year)
    {
        var query = Scripts.MonthlyOffering;
        return string.Format(query, churchId, month, year);
    }
    public static string MonthlyFirstFruits(string churchId, string month, string year)
    {
        var query = Scripts.MonthlyFirstFruits;
        return string.Format(query, churchId, month, year);
    }

}