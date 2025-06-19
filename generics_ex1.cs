// # why use generics?

// # type safety -> catch type errors at compile time

// # code reusability -> one implementation for multiple types

// # performance -> avoid boxing and unboxing with value types

using System;
using System.Collections.Generic;


List<int> intlist = new List<int>();
List<string> stringlist2 = new List<string>();

public class utilities
{
    public static void printitem<T>(T item)
    {
        Console.WriteLine(item);
    }
}

utilities.printitem<int>(42);

// class program
// {
//     static void Main()
//     {
//         List<int> intlist = new List<int>();
//         List<string> intlist2 = new List<string>();

//         utilities.printitem<int>(42);
//     }
// }