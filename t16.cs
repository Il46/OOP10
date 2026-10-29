using System;

public class NotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Сообщение: {message}");
    }

    public void SendNotification(string title, string message)
    {
        Console.WriteLine($"Заголовок: {title} | Сообщение: {message}");
    }

    public void SendNotification(string title, string message, string recipient)
    {
        Console.WriteLine($"Кому: {recipient} | Заголовок: {title} | Сообщение: {message}");
    }
}

class Program
{
    static void Main()
    {
        NotificationService ns = new NotificationService();
        ns.SendNotification("Ваш заказ готов.");
        ns.SendNotification("Статус заказа", "Ваш заказ готов.");
        ns.SendNotification("Статус заказа", "Ваш заказ готов.", "user@example.com");
    }
}
