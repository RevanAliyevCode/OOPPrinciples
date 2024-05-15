using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public int Radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            Area = Math.Round(Math.PI * (Radius * Radius), 2);
        }
    }
}
