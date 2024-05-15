using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Vehicle(string model, string name, string color)
        {
            Name = name;
            Model = model;
            Color = color;
        }

        public abstract void Info();
    }
}
