using System;

public class Geometry
{
    public double CalculateVolume(double side)
    {
        return Math.Pow(side, 3);
    }

    public double CalculateVolume(double length, double width, double height)
    {
        return length * width * height;
    }

    public double CalculateVolume(double radius, double height, bool isCylinder)
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }
}

class Program
{
    static void Main()
    {
        Geometry g = new Geometry();
        Console.WriteLine($"Объём куба: {g.CalculateVolume(3.0)}");
        Console.WriteLine($"Объём параллелепипеда: {g.CalculateVolume(2.0, 3.0, 4.0)}");
        Console.WriteLine($"Объём цилиндра: {g.CalculateVolume(2.0, 5.0, true)}");
    }
}