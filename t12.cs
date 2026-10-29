using System;
using System.Linq;

public class ArrayStats
{
    public void Analyze(int[] array, out int min, out int max, out double average)
    {
        min = array.Min();
        max = array.Max();
        average = array.Average();
    }

    public (double min, double max, double average) Analyze(double[] array)
    {
        return (array.Min(), array.Max(), array.Average());
    }
}

class Program
{
    static void Main()
    {
        ArrayStats stats = new ArrayStats();

        int[] intArr = { 10, 20, 30, 40, 50 };
        stats.Analyze(intArr, out int min, out int max, out double avg);
        Console.WriteLine($"int массив -> Мин: {min}, Макс: {max}, Среднее: {avg}");

        double[] doubleArr = { 1.5, 2.5, 3.5 };
        var res = stats.Analyze(doubleArr);
        Console.WriteLine($"double массив -> Мин: {res.min}, Макс: {res.max}, Среднее: {res.average}");
    }
}
