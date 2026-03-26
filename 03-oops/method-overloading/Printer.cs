namespace dotnet;

public class Printer()
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
    public void Print(string message, int count)
    {
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine(message);
        }
    }
}