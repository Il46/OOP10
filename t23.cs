using System;

public class ElectronicsStore
{
    public decimal CalculateFinalPrice(decimal price, decimal discount)
    {
        return Math.Max(0m, price - discount);
    }

    public decimal CalculateFinalPrice(decimal price, decimal discount, double taxRatePercent)
    {
        decimal discountedPrice = CalculateFinalPrice(price, discount);
        decimal tax = discountedPrice * (decimal)(taxRatePercent / 100.0);
        return discountedPrice + tax;
    }

    public decimal CalculateFinalPrice(decimal price, decimal discount, double taxRatePercent, decimal deliveryCost)
    {
        decimal priceWithTax = CalculateFinalPrice(price, discount, taxRatePercent);
        return priceWithTax + deliveryCost;
    }
}

class Program
{
    static void Main()
    {
        ElectronicsStore store = new ElectronicsStore();
        Console.WriteLine($"Цена со скидкой: {store.CalculateFinalPrice(50000m, 5000m)}");
        Console.WriteLine($"Цена со скидкой и налогом: {store.CalculateFinalPrice(50000m, 5000m, 12.0)}");
        Console.WriteLine($"Итоговая цена с доставкой: {store.CalculateFinalPrice(50000m, 5000m, 12.0, 1500m)}");
    }
}
