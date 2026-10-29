using System;

public class CurrencyConverter
{
    private const decimal FixedRate = 0.011m;

    public decimal ConvertCurrency(decimal amount)
    {
        return amount * FixedRate;
    }

    public decimal ConvertCurrency(decimal amount, decimal customRate, decimal feePercent)
    {
        decimal converted = amount * customRate;
        decimal fee = converted * (feePercent / 100m);
        return converted - fee;
    }
}

class Program
{
    static void Main()
    {
        CurrencyConverter converter = new CurrencyConverter();
        Console.WriteLine($"Конвертация по фиксированному курсу: {converter.ConvertCurrency(1000m)}");
        Console.WriteLine($"Конвертация по своему курсу с комиссией: {converter.ConvertCurrency(1000m, 0.012m, 2m)}");
    }
}
