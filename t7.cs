using System;
using System.IO;
using System.Text;

public class FileManager
{
    public void SaveFile(string path, string content)
    {
        File.WriteAllText(path, content);
    }

    public void SaveFile(string path, string[] lines)
    {
        File.WriteAllLines(path, lines);
    }

    public void SaveFile(string path, string content, Encoding encoding)
    {
        File.WriteAllText(path, content, encoding);
    }
}

class Program
{
    static void Main()
    {
        FileManager fm = new FileManager();
        fm.SaveFile("test1.txt", "Привет мир");
        fm.SaveFile("test2.txt", new string[] { "Первая строка", "Вторая строка" });
        fm.SaveFile("test3.txt", "Привет в UTF-8", Encoding.UTF8);
        Console.WriteLine("Файлы успешно сохранены.");
    }
}
