// single inheritance

// definition -> means a class only inherits from one base class


class Animal {
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
    static void Main() {
        Dog mydog = new Dog();
        mydog.Eat();
        mydog.Bark();
    }
}