// What are anonymous functions and lambda expressions?



// In C#, anonymous functions and lambda expressions are ways to define inline methods—that is, 
// methods without a name, often used to pass behavior as an argument (e.g., to LINQ, event handlers, etc.).


// Anonymous Functions
// These are functions without a name, defined using the delegate keyword.

Func<int, int, int> add = delegate(int x, int y)
{
    return x + y;
};

Console.WriteLine(add(2, 3)); // Output: 5


// Lambda Expressions
// A more concise way to write anonymous functions using the => syntax.

Func<int, int, int> add = (x, y) => x + y;

Console.WriteLine(add(2, 3)); // Output: 5

// Lambda expressions are anonymous functions, but written with a cleaner syntax.

// Use Cases
// LINQ queries:
var evens = numbers.Where(n => n % 2 == 0);

// Event handlers:
button.Click += (sender, e) => { Console.WriteLine("Clicked!"); };

// Custom sorting:
list.Sort((a, b) => a.CompareTo(b));