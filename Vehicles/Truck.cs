using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public Truck(string model, string name, string color, int loadCapacity) : base(model, name, color)
        {
            LoadCapacity = loadCapacity;
        }

        public override void Info()
        {
            Console.WriteLine($"Truck info:\n  Name: {Name}, Model: {Model}, Color: {Color}, Load Capacity: {LoadCapacity}kg");
        }
    }
}
