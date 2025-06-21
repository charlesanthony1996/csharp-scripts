// Call by Value (Default in C#)

// When a parameter is passed by value, a copy of the value is passed to the method. 
// Changes made to the parameter inside the method do not affect the original variable.

using System;

// class Program {
    // static void Main() {
        int num = 10;
        ModifyValue(num);
        Console.WriteLine("After call by value: " + num);

    // }

    static void ModifyValue(int x) {
        x = 20;
    }
// }

// In the example above, num remains 10 even after calling ModifyValue.