using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> num = new List<int>();
        
        //Add and AddRange
        num.Add(1);
        num.AddRange(new List<int> { 2, 3, 4, 5 });

        //Contains
        bool exists=num.Contains(8);
        Console.WriteLine(exists);

        //Remove and RemoveAt
        num.Remove(3);
        num.RemoveAt(0);
        foreach (var list in num)
        {
            Console.WriteLine(list);
        }
    }
}

// //🧠 Important Difference (Interview)
// Remove(value) → removes element
// RemoveAt(index) → removes position
