// ✅ Question 3
// Find the sum of numbers greater than 2
// int[] numbers = {1,2,3,4,5};
// 👉 Output:
// 12   // (3+4+5)

public class Program
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5 };
        var sum = num.Where(x => x > 2).Sum();
        var count = num.Where(x => x > 2).Count();
        var max = num.Max();
        Console.WriteLine($"Sum is:{sum}");
        Console.WriteLine($"Count is:{count}");
        Console.WriteLine($"Max is:{max}");
    }
}
