using System;

public class Warehouse
{
    private int stockCount;

    public int StockCount => stockCount;

    public void UpdateStock(int amount, bool isIncrease)
    {
        if (isIncrease)
        {
            stockCount += amount;
        }
        else
        {
            stockCount = Math.Max(0, stockCount - amount);
        }
    }

    public void UpdateStock(int newCount)
    {
        stockCount = Math.Max(0, newCount);
    }
}

class Program
{
    static void Main()
    {
        Warehouse wh = new Warehouse();
        wh.UpdateStock(50, true);
        Console.WriteLine($"Количество после увеличения: {wh.StockCount}");

        wh.UpdateStock(20, false);
        Console.WriteLine($"Количество после уменьшения: {wh.StockCount}");

        wh.UpdateStock(100);
        Console.WriteLine($"Новое установленное количество: {wh.StockCount}");
    }
}
