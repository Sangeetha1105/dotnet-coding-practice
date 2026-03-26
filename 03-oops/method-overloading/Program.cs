// ✅ Question 1 (Easy)
// Create class Printer with method Print:
// Print(string message) → print message
// Print(string message, int count) → print message count times
using dotnet;

namespace dotnet;
public class Program
{
    public static void Main(string[] args)
    {
        Printer printer=new Printer();
        printer.Print("hello World");
        printer.Print("hello",3);
    }
}
