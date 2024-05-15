using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product(string name, string description, int id, decimal price)
        {
            Name = name;
            Description = description;
            Id = id;
            Price = price;
        }

        public abstract void GetDetails();
    }
}
