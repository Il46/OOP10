using System;

public class MathLibrary
{
    public int Calculate(int a, int b, string operation)
    {
        return operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : 0,
            _ => 0
        };
    }

    public double Calculate(double a, double b, string operation)
    {
        return operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : double.NaN,
            _ => 0.0
        };
    }

    public decimal Calculate(decimal a, decimal b, char operation)
    {
        return operation switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => b != 0 ? a / b : 0m,
            _ => 0m
        };
    }
}

class Program
{
    static void Main()
    {
        MathLibrary ml = new MathLibrary();
        Console.WriteLine($"Сумма int: {ml.Calculate(10, 5, "+")}");
        Console.WriteLine($"Частное double: {ml.Calculate(10.5, 2.5, "/")}");
        Console.WriteLine($"Произведение decimal: {ml.Calculate(10m, 5m, '*')}");
    }
}
