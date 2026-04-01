👉 LINQ = Language Integrated Query

It lets you query data (arrays, lists, DB) easily.

Instead of loops like:

foreach(var x in numbers)
{
    if(x > 3)
        Console.WriteLine(x);
}

👉 You can write:

numbers.Where(x => x > 3);

Cleaner + powerful 🚀

🟢 Basic Structure
numbers.Where(x => condition)

👉 x => is called a lambda expression
👉 Read it as: “for each x”

🟡 Most Important LINQ Methods (Must know)
1. Where (Filter)

👉 Filters data

var result = numbers.Where(x => x % 2 == 0);

✔ Even numbers only

2. Select (Transform)

👉 Change values

var result = numbers.Select(x => x * 2);

✔ Multiply each number by 2

3. First / FirstOrDefault
numbers.First(x => x > 3);
numbers.FirstOrDefault(x => x > 10);

✔ FirstOrDefault returns 0 (or null) if nothing found

4. Count
numbers.Count(x => x > 2);

✔ Count numbers greater than 2

5. Sum
numbers.Sum();

✔ Total of all numbers

6. OrderBy
numbers.OrderBy(x => x);
numbers.OrderByDescending(x => x);

✔ Sorting

🧠 Important Concept (INTERVIEW 🔥)
IEnumerable vs IQueryable

👉 For now remember:

IEnumerable → works in memory (arrays, lists)
IQueryable → works with database (EF Core)

You’ll explain this later — don’t worry now 👍

🟢 Example (Full)
int[] numbers = {1,2,3,4,5,6};

var evenNumbers = numbers.Where(x => x % 2 == 0);

foreach(var num in evenNumbers)
{
    Console.WriteLine(num);
}



🧠 Key understanding (VERY IMPORTANT 🔥)
Method	Returns	Use case
Where()	Collection	Filter data
Count()	int	Count items

👉 So:

Want values → Where
Want number → Count

🟢 What is GroupBy?

👉 It groups data based on a condition

“Group elements that share the same key”

🟡 Simple Example
👉 Group numbers into Even / Odd
using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {1,2,3,4,5,6};

        var groups = numbers.GroupBy(x => x % 2 == 0);

        foreach (var group in groups)
        {
            Console.WriteLine(group.Key ? "Even" : "Odd");

            foreach (var num in group)
            {
                Console.WriteLine(num);
            }
        }
    }
}
💡 Output
False (Odd)
1
3
5

True (Even)
2
4
6
🧠 Key Concept
numbers.GroupBy(x => x % 2 == 0);

👉 x % 2 == 0 → key
👉 Group is created based on this key

🟡 Real Interview Example (Important ⭐)
👉 Group by value itself
int[] numbers = {1,1,2,2,3,3};

var groups = numbers.GroupBy(x => x);

foreach(var group in groups)
{
    Console.WriteLine($"Number: {group.Key}");

    foreach(var num in group)
    {
        Console.WriteLine(num);
    }
}
💡 Output
Number: 1 → 1,1
Number: 2 → 2,2
Number: 3 → 3,3