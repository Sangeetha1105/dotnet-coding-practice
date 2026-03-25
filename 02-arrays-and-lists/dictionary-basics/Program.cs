// Q1: Create a dictionary:
// Key: int (Id)
// Value: string (Name)
// 👉 Add:
// (1, "Sangeetha")
// (2, "Rahul")
// 👉 Print all key-value pairs

// Q2: Check if key exists before accessing:
// 👉 If key 1 exists → print value
// 👉 Else → print "Not found"


public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> employee = new Dictionary<int, string>();
        employee.Add(1, "Sangeetha");
        employee.Add(2, "Rahul");

        if (employee.ContainsKey(2))
        {
            Console.WriteLine(employee[2]); // correct
        }
        else
        {
            Console.WriteLine("Not found");
        }
        foreach (var emp in employee)
        {
            Console.WriteLine(emp.Key + "-" + emp.Value);
        }
    }
}
