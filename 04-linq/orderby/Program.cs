public class Program
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 8, 5, 4, 9 };
        var a = num.OrderBy(x => x);
        var b = num.OrderByDescending(x => x);
        Console.WriteLine("Desending order:");
        foreach (var des in b)
        {
            Console.WriteLine(des);
        }
        Console.WriteLine("Ascending order:");
        foreach (var asc in a)
        {
            Console.WriteLine(asc);
        }
    }
}