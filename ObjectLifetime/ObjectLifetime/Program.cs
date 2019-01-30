using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructors are used to put object into immediate valid state 
            Car myCar = new Car();
            Car.MyMethod();

            /*
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */

            // Immediately initializing values at moment of instantiation
            //Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            /*
            // Creating object that points to address of myCar
            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model, 
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myOtherCar = null;
            
            Console.WriteLine("{0} {1} {2} {3}",
               myOtherCar.Make,
               myOtherCar.Model,
               myOtherCar.Year,
               myOtherCar.Color);
             */
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Create a constructor
        /*
        public Car()
        {
            // You could load from a configuration file,a database, etc.
            Make = "Nissan";
            // Can also use this.Make to reference THIS declaration/member of the created class - don't need though
        }

        // Create an overloaded constructor that will initialize a new instance of a car with values at moment of instantiation
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        */

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod.");
        }
    }
}
