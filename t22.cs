using System;

public class TransportSystem
{
    public double CalculateFuelCost(double distance, double consumptionPer100Km)
    {
        return (distance / 100.0) * consumptionPer100Km;
    }

    public decimal CalculateFuelCost(double distance, double consumptionPer100Km, decimal fuelPricePerLiter)
    {
        double litersNeeded = (distance / 100.0) * consumptionPer100Km;
        return (decimal)litersNeeded * fuelPricePerLiter;
    }
}

class Program
{
    static void Main()
    {
        TransportSystem ts = new TransportSystem();
        Console.WriteLine($"Расход топлива в литрах: {ts.CalculateFuelCost(350.0, 8.0)}");
        Console.WriteLine($"Стоимость топлива: {ts.CalculateFuelCost(350.0, 8.0, 55.5m):C}");
    }
}
