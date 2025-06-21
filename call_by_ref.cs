// Call by Reference (ref or out keyword in C#)

// When a parameter is passed by reference, the method gets access to the original variable, 
// not just a copy. Changes will affect the original variable.

// using System;

// class Program {
    // static void Main() {
        int num = 10;
        ModifyByRef(ref num);
        Console.WriteLine("After modying the num is " + num);
    // }

    static void ModifyByRef(ref int x) {
        x = 20;
    }
// }

// The ref keyword must be used both in the method declaration and when calling it.




// call by ref -> using out keyword
// out keyword: Also passes by reference but for output-only parameters

// using System;

// class Program {
    // static void Main() {
        int result;
        GetOutput(out result);
        Console.WriteLine("Value from out parameter: " + result);

    // }

    public static void GetOutput(out int value) {
        value = 100;
    }
// }