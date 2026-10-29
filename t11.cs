using System;

public class ArraySorter
{
    public void Sort(int[] array)
    {
        Array.Sort(array);
    }

    public void Sort(double[] array)
    {
        Array.Sort(array);
    }

    public void Sort(string[] array)
    {
        Array.Sort(array);
    }
}

class Program
{
    static void Main()
    {
        ArraySorter sorter = new ArraySorter();

        int[] numbers = { 5, 2, 8, 1 };
        sorter.Sort(numbers);
        Console.WriteLine($"Отсортированный массив int: {string.Join(", ", numbers)}");

        double[] doubles = { 3.2, 1.1, 4.5 };
        sorter.Sort(doubles);
        Console.WriteLine($"Отсортированный массив double: {string.Join(", ", doubles)}");

        string[] strings = { "Банан", "Яблоко", "Апельсин" };
        sorter.Sort(strings);
        Console.WriteLine($"Отсортированный массив строк: {string.Join(", ", strings)}");
    }
}
