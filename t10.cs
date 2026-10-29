using System;

public class Library
{
    public void SearchBook(string title)
    {
        Console.WriteLine($"Поиск по названию: '{title}'");
    }

    public void SearchBook(string author, bool isAuthorSearch)
    {
        Console.WriteLine($"Поиск по автору: '{author}'");
    }

    public void SearchBook(string title, string author)
    {
        Console.WriteLine($"Поиск по названию '{title}' и автору '{author}'");
    }
}

class Program
{
    static void Main()
    {
        Library lib = new Library();
        lib.SearchBook("Война и мир");
        lib.SearchBook("Лев Толстой", true);
        lib.SearchBook("Война и мир", "Лев Толстой");
    }
}
