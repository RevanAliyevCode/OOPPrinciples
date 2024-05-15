using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public string Tip { get; set; }
        public string Reng { get; set; }

        public Animal(string ad, int yas, string tip, string reng)
        {
            Ad = ad;
            Yas = yas;
            Tip = tip;
            Reng = reng;
        }

        public abstract string MakeSound();
    }
}
