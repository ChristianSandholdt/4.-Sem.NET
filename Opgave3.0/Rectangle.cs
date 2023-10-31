using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._0
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double x, double y, double length, double width) : base(x, y)
        {
            Length = length;
            Width = width;
        }

        public string toString()
        {
            return "X: " + X + " Y:" + X + "values for the rectangle";
        }
        public override double area()
        {
            return Length * Width;
        }
    }
}
