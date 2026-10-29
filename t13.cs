using System;
using System.Linq;

public class PasswordValidator
{
    public bool ValidatePassword(string password, int minLength)
    {
        return password != null && password.Length >= minLength;
    }

    public bool ValidatePassword(string password, int minLength, bool requireDigits)
    {
        if (!ValidatePassword(password, minLength)) return false;
        return !requireDigits || password.Any(char.IsDigit);
    }

    public bool ValidatePassword(string password, int minLength, bool requireDigits, bool requireSpecialChars)
    {
        if (!ValidatePassword(password, minLength, requireDigits)) return false;
        return !requireSpecialChars || password.Any(ch => !char.IsLetterOrDigit(ch));
    }
}

class Program
{
    static void Main()
    {
        PasswordValidator validator = new PasswordValidator();
        Console.WriteLine($"Проверка длины (Pass123): {validator.ValidatePassword("Pass123", 6)}");
        Console.WriteLine($"Проверка длины и цифр (Password): {validator.ValidatePassword("Password", 6, true)}");
        Console.WriteLine($"Проверка спецсимволов (Pass123!): {validator.ValidatePassword("Pass123!", 6, true, true)}");
    }
}
