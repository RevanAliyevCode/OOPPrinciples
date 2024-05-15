using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person
    {
        public Student(string name, string surname) : base(name, surname) { }


        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}");
        }
    }
}
