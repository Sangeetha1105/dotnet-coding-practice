public class Program
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5 };
        var first = num.First(x => x > 3); //throws error if not correct
        var firstordefault = num.FirstOrDefault(x => x < 0);
        Console.WriteLine(first);
        Console.WriteLine(firstordefault);
    }
}
