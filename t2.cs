using System;

public class Student
{
    public double CalculateGrade(double score)
    {
        return score;
    }

    public double CalculateGrade(double score1, double score2)
    {
        return (score1 + score2) / 2.0;
    }

    public double CalculateGrade(double score1, double score2, double score3)
    {
        return (score1 + score2 + score3) / 3.0;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        Console.WriteLine($"Оценка по одному баллу: {student.CalculateGrade(85)}");
        Console.WriteLine($"Средний балл двух: {student.CalculateGrade(80, 90)}");
        Console.WriteLine($"Средний балл трёх: {student.CalculateGrade(70, 80, 90)}");
    }
}
