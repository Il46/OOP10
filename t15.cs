using System;

public class DateFormatter
{
    public string FormatDate(DateTime date)
    {
        return date.ToString("yyyy-MM-dd");
    }

    public string FormatDate(string dateString)
    {
        if (DateTime.TryParse(dateString, out DateTime parsedDate))
        {
            return parsedDate.ToString("dd.MM.yyyy");
        }
        return "Неверный формат";
    }

    public string FormatDate(DateTime date, bool includeTime)
    {
        return includeTime ? date.ToString("yyyy-MM-dd HH:mm:ss") : FormatDate(date);
    }
}

class Program
{
    static void Main()
    {
        DateFormatter df = new DateFormatter();
        DateTime now = DateTime.Now;
        Console.WriteLine($"Форматирование DateTime: {df.FormatDate(now)}");
        Console.WriteLine($"Форматирование строки: {df.FormatDate("2026-10-29")}");
        Console.WriteLine($"Форматирование со временем: {df.FormatDate(now, true)}");
    }
}
