using lab2.Interface;

namespace lab2.Servises;

public class DatabaseProxy : IDatabase
{
    private readonly RealDatabase _realDatabase;
    private readonly string _userRole;

    public DatabaseProxy(string userRole)
    {
        _userRole = userRole;
        _realDatabase = new RealDatabase();
    }

    public string Read(string query)
    {
        Console.WriteLine("[Proxy] Проверка прав для чтения...");
        return _realDatabase.Read(query);
    }

    public void Write(string query)
    {
        if (_userRole != "admin")
        {
            throw new UnauthorizedAccessException("Доступ запрещён: недостаточно прав для записи.");
        }

        Console.WriteLine("[Proxy] Проверка прав для записи... OK");
        _realDatabase.Write(query);
    }
}