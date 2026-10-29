using System;

public class DeliveryService
{
    public decimal CalculateDelivery(decimal baseRate)
    {
        return baseRate;
    }

    public decimal CalculateDelivery(decimal baseRate, bool isUrgent)
    {
        return isUrgent ? baseRate * 1.5m : baseRate;
    }

    public decimal CalculateDelivery(decimal baseRate, double weight, decimal ratePerKg)
    {
        return baseRate + (decimal)weight * ratePerKg;
    }
}

class Program
{
    static void Main()
    {
        DeliveryService ds = new DeliveryService();
        Console.WriteLine($"Обычная доставка: {ds.CalculateDelivery(500m)}");
        Console.WriteLine($"Срочная доставка: {ds.CalculateDelivery(500m, true)}");
        Console.WriteLine($"Доставка с учётом веса: {ds.CalculateDelivery(500m, 5.5, 50m)}");
    }
}
