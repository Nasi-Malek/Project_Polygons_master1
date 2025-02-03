using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Parallelogram : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side { get; set; }

        public Parallelogram(string name, double baseLength, double height, double side) : base(name)
        {
            Base = baseLength;
            Height = height;
            Side = side;
        }


        public override double CalculateArea() => Base * Height;
        public override double CalculatePerimeter() => 2 * (Base + Side);
    }
}
