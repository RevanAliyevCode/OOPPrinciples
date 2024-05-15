using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public int Side { get; set; }
        public int Height { get; set; }

        public Triangle(int side, int height)
        {
            Side = side;
            Height = height;
        }

        public override void CalculateArea()
        {
            Area = 0.5 * Height * Side;
        }
    }
}
