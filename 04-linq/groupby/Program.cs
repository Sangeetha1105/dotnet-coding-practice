// ✅ Question1
// Given:
// List<int> numbers = new List<int> {1,2,3,4,5,6};
// 👉 Group numbers into:
// Even
// Odd
// 👉 Print:
// Even: 2,4,6
// Odd: 1,3,5

//Q2 Create a List<Employee> with Name and Department, then use GroupBy to group employees by department.

using System.Net.Http.Headers;
public class Employee
{
    //? -if it is null no warning comes
    public string? Name{get;set;}
    public string? Department{get;set;}
}

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 9 };
        List<Employee> emp = new List<Employee>
        {
            new Employee{Name="Sangeetha",Department="IT"},
            new Employee{Name="Niv",Department="Networks"}

        };
        var empgroup = emp.GroupBy(x => x.Department);
        foreach (var empgroups in empgroup)
        {
            Console.WriteLine($"Department:{empgroups.Key}");
            Console.WriteLine("------------");
        }
        var groups = numbers.GroupBy(x => x % 2 == 0);
        foreach (var group in groups)
        {
            //Console.WriteLine($"{(group.Key ? "Even" : "odd")}: Count:{group.Count()}, Sum:{group.Sum()}");
            string label=group.Key ? "Even" : "odd";
            int count=group.Count();
            int sum=group.Sum();
            string values=string.Join(",",group);
            Console.WriteLine($"{label}:{values}");
            Console.WriteLine($"Count:{count}");
            Console.WriteLine($"Sum:{sum}");
            Console.WriteLine("------------");
        }
    }
}
