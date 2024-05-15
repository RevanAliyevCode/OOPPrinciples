using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public int PassengerCapacity { get; set; }

        public Car(string model, string name, string color, int passengerCapacity) : base(model, name, color)
        {
            PassengerCapacity = passengerCapacity;
        }

        public override void Info()
        {
            Console.WriteLine($"Car Info:\n  Name: {Name}, Model: {Model}, Color: {Color}, Passenger Capacity: {PassengerCapacity}");
        }
    }
}
