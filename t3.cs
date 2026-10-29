using System;

public class DiscountSystem
{
    public decimal CalculateDiscount(decimal amount, double percent)
    {
        return amount * (decimal)(percent / 100.0);
    }

    public decimal CalculateDiscount(decimal amount, decimal fixedDiscount)
    {
        return Math.Min(amount, fixedDiscount);
    }
}

class Program
{
    static void Main()
    {
        DiscountSystem ds = new DiscountSystem();
        Console.WriteLine($"Скидка в процентах: {ds.CalculateDiscount(1000m, 15.0)}");
        Console.WriteLine($"Скидка в фиксированной сумме: {ds.CalculateDiscount(1000m, 200m)}");
    }
}
