namespace lab2.Interface;

public interface IDatabase
{
    string Read(string query);
    void Write(string query);
}