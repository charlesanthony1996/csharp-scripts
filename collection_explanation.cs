// # list is a collection

// # List<T> is a generic collection in the System.Collections.Generic namespace
// # it represents a dynamically sized array of elements of type T

// # Type safe -> only stores elements of type T
// # Resizable -> automatically resizes as elements are added / removed
// # Indexed access -> Access elements using list[0], list[1] etc
// # Supports linq -> easily query and manipulate items
// # Built in methods -> Add(), Remove(), Insert(), Sort(), Find()

using System;
using System.Collections.Generic;


static void Main() {
        List<string> names = new List<string<();

        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        names.Insert(1, "David");

        names.Remove("Bob");

        foreach (var name in name) {
            Console.WriteLine(name);
        }

        Console.WriteLine($"Total names: {names.Count}");
}

// When to Use List<T>
// When you need indexed access to items

// When the size of your collection changes often

// When you want to perform searches, sorting, or LINQ queries