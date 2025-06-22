// self defined interfaces

// In C# (and most object-oriented languages), interfaces are contracts that define a set of methods, properties, events, or indexers 
// that a class or struct must implement. 
// Interfaces themselves contain no implementation—only the signature.

// system defined interfaces

// there are five built in -> in c#

// interface -> description

// 1. IDisposable -> provides a mechanism for rearranging unmanaged resources

// 2. IComparable -> defines a method for comparing objects to sort them

// 3. IEnumerable -> supports iteration using foreach

// 4. ICloneable -> supports cloning of objects

// 5. IEquatable -> defines a method for checking object equality

using System;

class Person : IComparable<Person> {
    public string Name { get; set; }

    public int CompareTo(Person other) {
        return this.Name.CompareTo(other.name);
    }
}

