using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double x, double y, double length, double width) : base(x, y)
        {
            this.Length = length;
            this.Width = width;
        }

        public String toString()
        {
            return "X: " + this.X + " Y:" + this.X + "values for the rectangle";
        }
        public override double area()
        {
            return this.Length * this.Width;
        }
    }
}
