using lab2.Interface;

namespace lab2.Servises;

public class RealDatabase : IDatabase
{
    public string Read(string query)
    {
        Console.WriteLine($"[RealDatabase] Выполняю чтение: {query}");
        return $"Результат запроса: {query}";
    }

    public void Write(string query)
    {
        Console.WriteLine($"[RealDatabase] Выполняю запись: {query}");
    }
}