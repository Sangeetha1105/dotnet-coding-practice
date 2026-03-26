🟢 List Basics (Quick Recap)
“Difference between array and list?”
Array → fixed size
List → dynamic (can grow/shrink)

Syntax:
List<int> numbers = new List<int>();

🟡 Most Important List Methods
1. Add (single item)
numbers.Add(1);
numbers.Add(2);
2. AddRange (multiple items)
numbers.AddRange(new List<int> {3, 4, 5});
3. Remove
numbers.Remove(2);   // removes value 2
4. RemoveAt
numbers.RemoveAt(0); // removes first element
5. Contains
bool exists = numbers.Contains(3);
6. Count
Console.WriteLine(numbers.Count);
7. Clear
numbers.Clear();
🧠 Important Difference (Interview)
Remove(value) → removes element
RemoveAt(index) → removes position

“What is Dictionary?”
“Dictionary stores data in key-value pairs and allows fast lookup using keys.”