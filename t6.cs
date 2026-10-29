using System;

public class GameScore
{
    private int totalScore;

    public int Score => totalScore;

    public int AddScore(int points)
    {
        totalScore += points;
        return totalScore;
    }

    public int AddScore(int points, int bonus)
    {
        totalScore += points + bonus;
        return totalScore;
    }

    public int AddScore(int points, double multiplier)
    {
        totalScore += (int)(points * multiplier);
        return totalScore;
    }
}

class Program
{
    static void Main()
    {
        GameScore game = new GameScore();
        Console.WriteLine($"Очки после базового добавления: {game.AddScore(100)}");
        Console.WriteLine($"Очки с бонусом: {game.AddScore(100, 50)}");
        Console.WriteLine($"Очки с множителем: {game.AddScore(100, 1.5)}");
    }
}
