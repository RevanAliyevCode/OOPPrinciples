using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Person
    {
        public Teacher(string name, string surname) : base(name, surname) { }


        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}");
        }
    }
}
