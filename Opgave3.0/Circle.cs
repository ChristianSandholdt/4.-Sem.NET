using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._0
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }


        public string toString()
        {
            return "X: " + X + " Y:" + X + "values for the circle";
        }

        public override double area()
        {
            return Math.PI * (Radius * Radius);
        }
    }


}
