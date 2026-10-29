using System;
using System.Linq;

public class GradingSystem
{
    public double EvaluateStudent(double examScore)
    {
        return examScore;
    }

    public double EvaluateStudent(double examScore, double testScore)
    {
        return (examScore + testScore) / 2.0;
    }

    public double EvaluateStudent(double[] examScores)
    {
        if (examScores == null || examScores.Length == 0) return 0.0;
        return examScores.Average();
    }
}

class Program
{
    static void Main()
    {
        GradingSystem gs = new GradingSystem();
        Console.WriteLine($"Оценка за один экзамен: {gs.EvaluateStudent(90.0)}");
        Console.WriteLine($"Среднее за экзамен и контрольную: {gs.EvaluateStudent(90.0, 80.0)}");
        Console.WriteLine($"Среднее за несколько экзаменов: {gs.EvaluateStudent(new double[] { 85.0, 92.0, 78.0 })}");
    }
}
