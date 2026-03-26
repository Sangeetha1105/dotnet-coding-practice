public class Program
{
    public static void Main(string[] args)
    {
        List<int> num = new List<int>{1,2,3,4,5};
        var even=num.Where(x=>x%2==0);
        foreach(var list in even)
        {
            Console.WriteLine(list);
        }
    }
}

