using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int x, int y, int radius) : base( x,  y){
            this.Radius = radius;
        }


        public String toString()
        {
            return "X: " + this.X + " Y:" + this.X + "values for the circle";
        }

        public override double area()
        {
            return Math.PI*(this.Radius*this.Radius);
        }
    }


}
