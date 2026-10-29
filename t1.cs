using System;

public class Car
{
    public void ShowInfo(string brand)
    {
        Console.WriteLine($"Марка: {brand}");
    }

    public void ShowInfo(string brand, int year)
    {
        Console.WriteLine($"Марка: {brand}, Год выпуска: {year}");
    }

    public void ShowInfo(string brand, int year, decimal price)
    {
        Console.WriteLine($"Марка: {brand}, Год выпуска: {year}, Цена: {price:C}");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.ShowInfo("Toyota");
        car.ShowInfo("Toyota", 2020);
        car.ShowInfo("Toyota", 2020, 2500000m);
    }
}
