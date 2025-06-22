// custom defined interfaces -> user defined interfaces

// these are user created interfaces in your own code. you define them to ensure certain classes follow a specific 
// contract in your application

// why use them

// -> enforce structure
// -> enable polymorphism
// -> seperate abstration from implementation

public interface IShape {
    double GetArea();
    double GetPerimeter();
}

public class Circle : IShape {
    public double Radius { get; set; }

    public double GetArea() => Math.PI * Radius * Radius;
    public double GetPerimeter() => 2 * Math.PI * Radius;
}

// here IShape is a self defined interface that could be implemented by many shape classes like Circle, Rectangle


// summary of system defined interfaces vs self defined interfaces

// type -> who defines it -> examples -> use case

// system defined -> .net framework -> IDisposable , IEnumerable -> Common tasks in c# and .net

// self defined -> you/ your team -> IShape, IRepository -> Custom contracts for app specific logic


// | Type               | Who defines it? | Examples                     | Use Case                                |
// | ------------------ | --------------- | ---------------------------- | --------------------------------------- |
// | **System-Defined** | .NET Framework  | `IDisposable`, `IEnumerable` | Common tasks in C# and .NET             |
// | **Self-Defined**   | You / your team | `IShape`, `IRepository`      | Custom contracts for app-specific logic |
