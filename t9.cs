using System;

public class Taxi
{
    public decimal CalculateFare(double distanceKm, decimal pricePerKm)
    {
        return (decimal)distanceKm * pricePerKm;
    }

    public decimal CalculateFare(double distanceKm, decimal pricePerKm, int waitMinutes, decimal pricePerWaitMinute)
    {
        return ((decimal)distanceKm * pricePerKm) + (waitMinutes * pricePerWaitMinute);
    }

    public decimal CalculateFare(double distanceKm, decimal pricePerKm, double classMultiplier)
    {
        return (decimal)distanceKm * pricePerKm * (decimal)classMultiplier;
    }
}

class Program
{
    static void Main()
    {
        Taxi taxi = new Taxi();
        Console.WriteLine($"По расстоянию: {taxi.CalculateFare(10.0, 50m)}");
        Console.WriteLine($"С ожиданием: {taxi.CalculateFare(10.0, 50m, 10, 10m)}");
        Console.WriteLine($"С классом авто: {taxi.CalculateFare(10.0, 50m, 1.5)}");
    }
}
