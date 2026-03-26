// ✅ Question 1
// Create a class Employee with:
// private field: salary
// public property: Salary
// Then:
// Set salary = 5000
// Print salary

public class Employee
{
    private int salary;
    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Salary = 5000; //set
        Console.WriteLine(emp.Salary); //get(print)
    }
}
