// ✅ Question 2
// Create:
// Parent class: Shape → method Draw() (print "Drawing shape")
// Child class: Circle → override Draw() (print "Drawing circle")
using System.Reflection.Metadata;

namespace DOTNET;

public class Program
{
    public static void Main(string[] args)
    {
        Shape shape=new Circle();
        shape.Draw();
    }
}
