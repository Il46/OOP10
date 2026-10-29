using System;
using System.Linq;

public class Helper
{
    public int Calculate(int a, int b)
    {
        return a + b;
    }

    public double Calculate(double a, double b)
    {
        return a * b;
    }

    public string Format(double number)
    {
        return number.ToString("N2");
    }

    public string Format(string str)
    {
        return str.Trim().ToUpper();
    }

    public string Format(DateTime date)
    {
        return date.ToString("dd.MM.yyyy HH:mm");
    }

    public int Find(int[] array, int value)
    {
        return Array.IndexOf(array, value);
    }

    public int Find(string source, string value)
    {
        return source.IndexOf(value, StringComparison.OrdinalIgnoreCase);
    }

    public void Display(int number)
    {
        Console.WriteLine($"Число: {number}");
    }

    public void Display(string text)
    {
        Console.WriteLine($"Текст: {text}");
    }

    public void Display(DateTime date)
    {
        Console.WriteLine($"Дата: {date:yyyy-MM-dd}");
    }
}

class Program
{
    static void Main()
    {
        Helper helper = new Helper();

        Console.WriteLine($"Calculate(int, int): {helper.Calculate(5, 10)}");
        Console.WriteLine($"Calculate(double, double): {helper.Calculate(2.5, 4.0)}");

        Console.WriteLine($"Format(double): {helper.Format(1234.567)}");
        Console.WriteLine($"Format(string): {helper.Format("  hello world  ")}");
        Console.WriteLine($"Format(DateTime): {helper.Format(DateTime.Now)}");

        int[] numbers = { 10, 20, 30, 40 };
        Console.WriteLine($"Find(int[], int): Индекс элемента 30 = {helper.Find(numbers, 30)}");
        Console.WriteLine($"Find(string, string): Индекс подстроки = {helper.Find("Привет мир", "мир")}");

        helper.Display(100);
        helper.Display("Демонстрация работы класса Helper");
        helper.Display(DateTime.Now);
    }
}
