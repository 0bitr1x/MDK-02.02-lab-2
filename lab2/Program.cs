using System;
using lab2.Interface;
using lab2.Servises;

class Program
{
    static void Main()
    {
        try
        {
            var userDb = new DatabaseProxy("user");
            Console.WriteLine(userDb.Read("SELECT * FROM users;"));
            userDb.Write("DELETE FROM users;"); // Вызовет исключение
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.WriteLine(new string('-', 30));

        try
        {
            var adminDb = new DatabaseProxy("admin");
            Console.WriteLine(adminDb.Read("SELECT * FROM logs;"));
            adminDb.Write("INSERT INTO logs VALUES ('hack attempt');");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}