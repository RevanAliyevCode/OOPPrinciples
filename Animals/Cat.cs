using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string ad, int yas, string cins, string reng) : base(ad, yas, cins, reng) { }

        public override string MakeSound()
        {
            return "Miyav";
        }
    }
}
