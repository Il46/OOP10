using System;

public class Book
{
    public void DisplayBook(string title)
    {
        Console.WriteLine($"Название: {title}");
    }

    public void DisplayBook(string title, string author)
    {
        Console.WriteLine($"Название: {title}, Автор: {author}");
    }

    public void DisplayBook(string title, string author, int year)
    {
        Console.WriteLine($"Название: {title}, Автор: {author}, Год издания: {year}");
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book();
        book.DisplayBook("Преступление и наказание");
        book.DisplayBook("Преступление и наказание", "Фёдор Достоевский");
        book.DisplayBook("Преступление и наказание", "Фёдор Достоевский", 1866);
    }
}
