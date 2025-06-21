// 1. class

// a class is a blue print for creating objects. it defines properties (variables) and methods (functions) that
// the objects created from the class will have

using System;

public class Car {
    public string Make;
    public string Model;

    public void Drive() {
        Console.WriteLine("The car is driving!");
    }
}

// 2. inheritance

// inheritance allows on class (child/derived) to inherit members (field, properties, methods) from another
// class (parent/base).
// This promotes code reuse

public class Vehicle {
    public void Start() {
        Console.WriteLine("Vehicle started");
    }
}

public class Car : Vehicle {
    public void Drive() {
        Console.WriteLine("Car is driving");
    }
}

Car mycar = new Car();
mycar.Start();
mycar.Drive();


// 3. polymorphism 

// polymorphism means "many forms". it allows methods to do different things based on the object that is calling them
// there are two types

// -> 1. compile time (method overloading)
// -> 2. run time (method overriding)

// method overloading (compile time)

public class Printer {
    public void Print(string text) {
        Console.WriteLine(text);
    }

    public void Print(int number) {
        Console.WriteLine(number);
    }
}

// method overriding (run time)

public class Animal {
    public virtual void Speak() {
        Console.WriteLine("Animal speaks");
    }
}

public class Animal : Dog {
    public override void Speak() {
        Console.WriteLine("Dog barks");
    }
}

// 4. Generics

// Generics allow you to define classes, methods or interfaces with a placeholder for the data type.
// This promotes type safety and code reuse

public class Box<T> {
    public T Value;

    public void Display() {
        Console.WriteLine(value);
    }
}

Box<int> intbox = new Box<int>();
intbox.Value = 42

Box<string> strBox = new Box<string>();
strBox.Value = 'Charles'


// 5. Abstraction

// abstraction hides complex implementation details and exposes only the necessary parts.
// this is usually achieved using abstract classes or interfaces

// abstract class example

public abstract class Shape {
    public abstract double Area();
}

public class Circle : Shape {
    public double radius;

    public Circle(double radius) {
        Radius = radius;
    }

    public override double Area() {
        return Math.PI * Radius * Radius;
    }
}


// interface example

public interface IAnimal {
    void Speak();
}

public class Cat : IAnimal {
    public void Speak() {
        Console.WriteLine("Meow");
    }
}

// summary table

// concept -> description -> c# keyword

// class -> blueprint for objects -> class