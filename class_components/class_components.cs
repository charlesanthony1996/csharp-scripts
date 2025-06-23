using System;

class Program {
    public static void Main() {
        // Console.WriteLine("Hello");
        Car mycar = new Car("Toyota", 2008);
        mycar.Drive();
    }

    public class Car {
        private string brand;
        public string color;

        public string Brand {
            get { return brand; }
            set { brand = value; }
        }

        public int Year  { get;  set; }


        public Car() {
            brand = "unknown";
            Year = 2000;
        }

        public Car(string brand, int year) {
            this.brand = brand;
            this.Year = year;
        }

        public void Drive() {
            Console.WriteLine($"Driving a {brand}...");
        }

    }
}


// access modifiers in c#

// public
// private
// protected -> accessible for that class and derived classes
// internal -> accessible within the same assembly. (what does assembly mean?)
// protected internal -> accessible within the same assembly or from derived classes
// private protected -> accessible only within the containing class or derived classes in the same assembly

//  What is an Assembly in C#?
// An assembly is the compiled output of your C# project — usually a:

// .exe file (if it's an application)

// .dll file (if it's a library)

// You can think of an assembly as a bundle of compiled code that the .NET runtime can execute or reference.