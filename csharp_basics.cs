// Explain C# basics. What are int, float, and double data types? 
// How can you convert between these three types safely using implicit casting or explicit casting?

// Basic C# Data Types

// | Type     | Description                           | Size             | Example            |
// | -------- | ------------------------------------- | ---------------- | ------------------ |
// | `int`    | Integer (whole number)                | 4 bytes (32-bit) | `int x = 10;`      |
// | `float`  | Floating point number (less precise)  | 4 bytes (32-bit) | `float y = 10.5f;` |
// | `double` | Double precision float (more precise) | 8 bytes (64-bit) | `double z = 10.5;` |


// Casting Between Types

// Implicit Casting (Safe, automatic)
// Done automatically when there is no risk of data loss.

int i = 100;
float f = i;     // int to float
double d = f;    // float to double


// Output:

// Console.WriteLine(f); // 100
// Console.WriteLine(d); // 100


// Safe because float and double can hold all int values.

// Explicit Casting (Manual, potential data loss)
// Required when data might be lost, like from double to int.


double d = 9.78;
float f = (float)d;  // double to float
int i = (int)d;      // double to int


//  Output:

Console.WriteLine(f); // 9.78 (some precision may be lost)
Console.WriteLine(i); // 9    (decimal part is cut off)


//  Example: Converting between int, float, and double

using System;

class Program {
    static void Main() {
        int i = 42;
        float f = i;             // Implicit cast
        double d = f;            // Implicit cast

        Console.WriteLine($"Int: {i}");
        Console.WriteLine($"Float: {f}");
        Console.WriteLine($"Double: {d}");

        // Explicit cast from double to float and int
        double pi = 3.14159;
        float piFloat = (float)pi;  // Explicit
        int piInt = (int)pi;        // Explicit

        Console.WriteLine($"Double (pi): {pi}");
        Console.WriteLine($"Float (pi): {piFloat}");
        Console.WriteLine($"Int (pi): {piInt}");
    }
}


// Tips

// Use float when memory is limited or when precision is less critical. Append f to literals: 3.14f.

// Use double by default for real numbers unless you need more performance.

// Always use explicit casting if you're going from a larger to a smaller type to avoid unintended behavior.

