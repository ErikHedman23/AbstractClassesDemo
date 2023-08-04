using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        

        public override void DriveAbstract()
        {
            Console.WriteLine($"I love abstractly driving my {Make} {Model}"); //if you want to inherit the properties of the parent class, you can type this.Model for example to get the original value of the property.
        }

        public virtual void DriveVirtual() //you actually dont need to put this in this class since you are leaving it as the base value.  It will naturally inherit the base value if you call the method in the main.
        {
            base.DriveVirtual();
        }
    }
}
