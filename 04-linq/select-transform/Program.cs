// ✅ Question 2
// Multiply all numbers by 2 using LINQ
// int[] numbers = {1,2,3,4};
// 👉 Output:
// 2
// 4
// 6
// 8

public class Program
{
    public static void Main(string[] args)
    {
        int[] num={1,2,3,4,5};
        var mul=num.Select(x=>x*2);
        foreach(var multiply in mul)
        {
            Console.WriteLine(multiply);
        }
    }
}