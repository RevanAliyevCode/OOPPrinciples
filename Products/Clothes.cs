using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Clothes : Product
    {
        public string Size { get; set; }
        public Clothes(string name, string description, int id, string size, decimal price) : base(name, description, id, price)
        {
            Size = size;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Size: {Size}");
        }
    }
}
