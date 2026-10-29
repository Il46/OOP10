using System;

public class AuthService
{
    public bool Login(string username, string password)
    {
        Console.WriteLine($"Вход по логину: {username}");
        return true;
    }

    public bool Login(string email, string password, bool isEmail)
    {
        Console.WriteLine($"Вход по email: {email}");
        return true;
    }

    public bool Login(string username, string password, string confirmationCode)
    {
        Console.WriteLine($"Вход по логину {username} с кодом подтверждения: {confirmationCode}");
        return true;
    }
}

class Program
{
    static void Main()
    {
        AuthService auth = new AuthService();
        auth.Login("user1", "pass123");
        auth.Login("user1@mail.com", "pass123", true);
        auth.Login("user1", "pass123", "9988");
    }
}
