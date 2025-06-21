// nested inheritance

// definition -> nested or multi level inheritance means a class inherits from a class which inherits from another class
// -> forming a chain

using System;

class LivingThing {
    public void Grow() {
        Console.WriteLine("Growing...");
    }
}

class Animal : LivingThing {
    public void Eat() {
        Console.WriteLine("Eating...");
    }
}

class Dog : Animal {
    public void Bark() {
        Console.WriteLine("Barking...");
    }
}

class Program {
    public static void Main() {
        Dog mydog = new Dog();
        mydog.Bark();
        mydog.Eat();
        mydog.Grow();
    }
}

// 🔒 Note on C# and Multiple Inheritance
// C# does not support multiple inheritance 
// (i.e., inheriting from more than one class), but it allows implementing multiple interfaces to achieve similar results.


// What C# Does Not Support: Multiple Inheritance of Classes
// Multiple inheritance would look like this (which is not allowed in C#):


// class A { }
// class B { }
// class C : A, B { }  // ❌ Error in C#
// This would mean C inherits from both A and B. 
// C# does not allow this kind of structure to avoid ambiguity 
// (e.g., if both base classes had a method with the same name).


