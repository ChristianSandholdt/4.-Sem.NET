using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._0
{
    internal abstract class Shape
    {
        public double X { get; }
        public double Y { get; }

        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Shape() : this(1, 1)
        {
        }

        public abstract double area();



    }
}
