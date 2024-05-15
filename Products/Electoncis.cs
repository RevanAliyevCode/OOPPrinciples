using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Electoncis : Product
    {
        public string Material { get; set; }
        public Electoncis(string name, string description, int id, string material, decimal price) : base(name, description, id, price)
        {
            Material = material;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Material: {Material}");
        }
    }
}
