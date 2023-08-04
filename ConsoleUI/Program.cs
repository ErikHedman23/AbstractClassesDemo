using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            List<Vehicle> vehicles = new List<Vehicle>(); //if you put your list inside of the abstract class, you will be unable to access it in the main method...
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            Car car = new Car();

            car.Year = 1999;
            car.Make = "Honda";
            car.Model = "Accord";
            car.HasTrunk = true;
            vehicles.Add(car);
            Motorcycle mc = new Motorcycle();
            mc.Year = 2020;
            mc.Make = "Harley Davidson";
            mc.Model = "Nightster";
            mc.HasSideCart = false;
            vehicles.Add(mc);
            Vehicle jeep = new Car();
            jeep.Year = 2021;
            jeep.Make = "Jeep";
            jeep.Model = "Rubicon";
            vehicles.Add(jeep);
            Vehicle indian = new Motorcycle();
            indian.Year = 1990;
            indian.Make = "Indian";
            indian.Model = "Scout";
            vehicles.Add(indian);

            foreach (Vehicle carcycle in vehicles) 
            {
                Console.WriteLine($"{carcycle.Year}\n  {carcycle.Make}\n   {carcycle.Model}");
            }

            car.DriveAbstract();
            car.DriveVirtual();
            mc.DriveAbstract();
            mc.DriveVirtual();
                
            
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine(); //Use this to end your code...
        }
    }
}
