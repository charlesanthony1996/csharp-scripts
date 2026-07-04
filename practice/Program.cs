// generics

using System;
using System.Collections.Generic;

public class Box<T> {
    public T Value;

}

public interface IDrawable {
    void Draw();
}

// Box<int> intbox = new Box<int> { Value = 5 };
// Box<string> strBox = new Box<string> { Value = "Hello"};

public class Circle: IDrawable {
    public void Draw() {
        Console.WriteLine("Drawing...");
    }
}

public class Program {
    public static void Main() {
        Box<int> intbox = new Box<int> { Value = 5};
        Box<string> strbox = new Box<string> { Value = "Charles"};

        Console.WriteLine("Hello world");
        Console.WriteLine(intbox.Value);
        Console.WriteLine(strbox.Value);
    }
}
