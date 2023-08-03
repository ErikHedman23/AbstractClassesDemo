using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        
        public int Year { get; set; } = 1999;
        public string Make { get; set; } = "Jeep";
        public string Model { get; set; } = "Wrangler";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
    {
        Console.WriteLine($"I love driving my {Year} {Make} {Model}");
    }
    }
}
