// ✅ Question 1 (Easy)
// Create a class Student:
// private field: age
// public property: Age
// 👉 In Main:
// Set age = 25
// Print age

// ✅ Question 2 (Important 🔥)
// Add validation:
// 👉 Salary should not be negative
// If user sets negative value → print:
// Invalid salary

// ✅ Question 3 (Interview Level ⭐)
// Create class BankAccount:
// private field: balance
// property: Balance
// 👉 Rules:
// Cannot set negative balance
// Cannot set balance > 1,00,000

public class Student
{
    //ANS3:
    private int balance;
    public int Balance
    {
        get { return balance; }
        set
        {
            if (value > 100000 || value < 0)
            {
                Console.WriteLine("Cannot set negative balance or cannot set balnce >1,00,000");
            }
            else
            {
                value=balance;
            }
        }
    }
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Balance=9888777;
        Console.WriteLine(student.Balance);
    }










    //ANS2:// private int salary;
    // public int Salary
    // {
    //     get { return salary; }
    //     set
    //     {
    //         if (value < 0)
    //         {
    //             Console.WriteLine("Invalid Salary");
    //         }
    //         else
    //         {
    //               salary=value;
    //         }
    //     }
    // }
    // public static void Main(string[] args)
    // {
    //     Student student=new Student();
    //     student.Salary=-9;
    //     Console.WriteLine(student.Salary);
    // }









    //ANS1// private int age;
    // public int Age
    // {
    //     get { return age; }
    //     set { age = value; }
    // }
    // public static void Main(string[] args)
    // {
    //     Student student = new Student();
    //     student.Age = 25;
    //     Console.WriteLine(student.Age);
    // }
}