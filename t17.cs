using System;

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string position = "Не указана", decimal salary = 0m)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Имя: {Name}, Должность: {Position}, Зарплата: {Salary:C}";
    }
}

public class EmployeeManager
{
    public Employee CreateEmployee(string name)
    {
        return new Employee(name);
    }

    public Employee CreateEmployee(string name, string position)
    {
        return new Employee(name, position);
    }

    public Employee CreateEmployee(string name, string position, decimal salary)
    {
        return new Employee(name, position, salary);
    }
}

class Program
{
    static void Main()
    {
        EmployeeManager em = new EmployeeManager();
        Console.WriteLine(em.CreateEmployee("Иван"));
        Console.WriteLine(em.CreateEmployee("Иван", "Разработчик"));
        Console.WriteLine(em.CreateEmployee("Иван", "Разработчик", 150000m));
    }
}
