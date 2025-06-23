using System;

class Program {
    public static void Main() {
        // Console.WriteLine("Hello");
        Car mycar = new Car("Toyota", 2008);
        mycar.Drive();
    }

    public class Car {
        private string brand;

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