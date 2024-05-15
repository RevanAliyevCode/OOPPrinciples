using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryTask
{
    public class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Books(string name, string author, decimal price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
    }
}
