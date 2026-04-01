// ✅ Question 1
// Using LINQ, print numbers greater than 3
// int[] numbers = {1,2,3,4,5};
// 👉 Output:
// 4
// 5
public class Program
{
    public static void Main(string[] args)
    {
        int[] num={1,2,3,4,5};
        var numbers=num.Where(x=>x>3);
        foreach(var great in numbers)
        {
            Console.WriteLine(great);
        }
    }
}
