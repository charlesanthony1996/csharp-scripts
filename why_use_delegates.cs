// # a delegate is a type safe function pointer. it holds a reference to a method

// # meaning it can point to any method with a matching signature

// # why use delegates

// # 1. The allow you to pass methods as parameters

// # 2. They enable callbacks and event handling

// # 3. They support flexible, dynamic method invocation


// # more tips on what delegates are

// # -> a delegate is like a blueprint describing a method signature -- which parameters and return type a method must have

// # -> when you create a delegate instance, you assign it a method that matches that signature

// # -> then you can call the method via the delegate instance

using System;

delegate void Printer(int number);

class Program {
    static void PrintNumber(int num) {
        Console.WriteLine("Number is: " + num);
    }

    static void Main() {
        Printer p = PrintNumber;

        p(42);

        Printer p2 = n => Console.WriteLine("Lambda print: " + n);
        p2(99);
    }
}